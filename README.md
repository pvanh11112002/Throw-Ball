# Throw-Ball
 EXP:

 - Không nên lạm dụng Singleton quá nhiều
 - Nên tận dụng khả năng kéo thả của unity
 - Hạn chế tối đa việc sử dụng FindGameObjectWithTag hoặc Find vì nếu trong project lớn thì sẽ có đến hàng nghìn object, dẫn tới việc phải tìm liên tục, rất tốn hiệu năng
 - OnEnable chỉ nên dùng cho gameobject, chứ không phải script, và nếu được thì nên hạn chế tối đa việc dùng onenable
 - Trong 1 scene gồm nhiều gameobject với nhiều script thì nên tối đa hóa khả năng quản lý luồng bằng việc sử dụng duy nhất 1 hàm awake, hoặc ít nhất có thể
 - RaycastTarget nhẹ hẹn trigger khá nhiều
