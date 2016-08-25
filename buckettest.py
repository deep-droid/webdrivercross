class Bucket(object):
	def __init__(self, size):
		self._size = size
		self._water = 0

	def get_Size(self):
		return self._size

	def set_Size(self, value):
		self._size = value

	#Size = property(fget=get_Size, fset=set_Size)

	def get_Water(self):
		return self._water

	def set_Water(self, value):
		self._water = value

	#Water = property(fget=get_Water, fset=set_Water)

	def FillBucket(self):
		self._water = self.Size

	def EmptyBucket(self):
		self._water = 0

	def RemoveSomeWater(self, x):
		self._water = self.Water - x

	def AddWater(self, bucket):
		temp = self.Size - self.Water
		if self.Water + bucket.Water <= self.Size:
			self._water += bucket.Water
			bucket.EmptyBucket()
		else:
			self._water += temp
			bucket.RemoveSomeWater(temp)

	def BucketStatus(self):
		print("Size:  ", self.Size)
		print("Water: ", self.Water)
		print("----------")

bucket5 = Bucket(5)
bucket3 = Bucket(3)
bucket5.BucketStatus()
bucket3.BucketStatus()

bucket3.FillBucket()
bucket5.AddWater(bucket3)
#bucket5.BucketStatus()
#bucket3.BucketStatus()

bucket3.FillBucket()
#bucket5.BucketStatus()
#bucket3.BucketStatus()

bucket5.AddWater(bucket3)
#bucket5.BucketStatus()
#bucket3.BucketStatus()

bucket5.EmptyBucket()
bucket5.AddWater(bucket3)
#bucket5.BucketStatus()
#bucket3.BucketStatus()

bucket3.FillBucket()
bucket5.AddWater(bucket3)
bucket5.BucketStatus()
bucket3.BucketStatus()

