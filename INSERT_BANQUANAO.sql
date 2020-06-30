USE WebTHKids
GO



INSERT INTO QUANTRIVIEN VALUES (01, 'Admin1', 'Admin1'),
                               (02, 'Admin2', 'Admin2')

INSERT INTO NHANVIEN VALUES (01, N'Nguyễn Thị Hương Trang', N'HuongTrang', 'HuongTrang', '01/01/2020'),
                            (02, N'Đinh Thị Hoài', N'DinhHoai', 'DinhHoai311', '01/01/2020'),
							(03, N'Bùi Trung Tú', N'TrungTu123', 'BTT123', '03/15/2020'),
							(04, N'Nguyễn Thị Thu Hà', N'ThuHa72', 'ThuHa', '05/25/2020'),
							(05, N'Trịnh Đức Nhật Minh', N'NhatMinh', 'NhatMinh311', '03/11/2020')

INSERT INTO KHACHHANG VALUES (00001, N'Mai Ngọc Lệ', 'maingocle123@gamil.com', N'Nghĩa Tân, Cầu Giấy, Hà Nội', 0368185590, 'NgocLe', 123456, null, null, '04/04/2020'),
                             (00002, N'Trần Thị Huyền', 'tranhuyen1994@gmail.com', N'Mễ Trì, Nam Từ Liêm, Hà Nội', 0354053097, 'TranHuyen', 123456, null, null, '04/04/2020'),
							 (00003, N'Trịnh Như Ngọc', 'ngoctrinh1990@gmail.com', N'Hạ Đình, Thanh Xuân, Hà Nội', 0352033567, 'NgocTrinh',643865,null, null, '04/05/2020'),
							 (00004, N'Nguyễn Xuân Trung', 'xuanntrung1990@gmail.com', N'Hạ Đình, Thanh Xuân, Hà Nội', 0354523567, 'XuanTrung', 24823, null, null,'04/05/2020'),
							 (00005, N'Nguyễn Thị Anh', 'nguyenanh1988@gmail.com', N'Nguyen Khanh Toan, Cau Giay, Ha Noi', 0353033567, 'NguyenAnh', 324328, null, null,'04/05/2020'),
							 (00006, N'Nguyễn Thị Bích Ngọc', 'ngocbich192@gmail.com', N'25 Han Thuyen, Hai Ba Trung, Ha Noi', 0352012367, 'BichNgoc', 123214, null, null, '04/05/2020'),
							 (00007, N'Bùi Thị Trà My', 'tramy123@gmail.com', N'Giang Vo, Cat Linh, Dong Da, Ha Noi', 0353564567, 'TraMy', 486348, null, null, '04/06/2020'),
							 (00008, N'Đinh Văn Lực', 'dinhluc0123@gmail.com', N'Khuat Duy Tien, Trung Hoa, Cau Giay, Ha Noi', 0352011267, 'DinhLuc', 745289, null, null, '04/06/2020'),
							 (00009, N'Nguyễn Hoàng', 'nguyenhoang@gmail.com', N'Co Nhue 2, Bac Tu Liem, Ha Noi', 0352765567, 'NguyenHoang', 3246276, null, null, '04/15/2020'),
							 (00010, N'Nguyễn Thị Thuỳ Linh', 'thuylinh1999@gmail.com', N'210 Hoàng Quoc Viet, Cau Giay, Ha Noi', 0352055667, 'ThuyLinh', 385896, null, null, '04/20/2020'),
							 (00011, N'Trần Thị Nga', 'ngatran668@gmail.com', N'22 ngo 32 Do Duc Duc, Nam Tu Liem, Ha Noi', 0352039867, 'NgaTran', 853853, null, null, '04/20/2020'),
							 (00012, N'Nguyễn Thị Mai', 'nguyenmai0@gmail.com', N'Tan Lap, Dan Phuong, Ha Noi', 0352789567, 'NguyenMai', 348223, null, null, '04/22/2020'),
							 (00013, N'Phạm Mai Anh', 'maianh@gmail.com', N'Hồ Tùng Mậu, Mai Dịch, Cầu Giấy, Hà Nội', 0367833567, 'MaiAnh', 4856345, null, null, '04/25/2020'),
							 (00014, N'Nguyễn Thị Nga', 'nguyenthinga1503@gmail.com', N'ngõ 7 Phạm Văn Đồng, Cổ Nhuế 1, Bắc Từ Liêm, Hà Nội', 0365733567, 'NguyenNga', 2348238, null, null, '04/25/2020'),
							 (00015, N'Nguyễn Văn Minh', 'nguyenminh12340@gmail.com', N'SN 34 ngõ 13 Xuân Thủy, Cầu Giấy, Hà Nội', 0352089567, 'NguyenMinh', 845835, null,null, '04/26/2020'),
							 (00016, N'Nguyễn Vũ Hải Anh', 'haianh5678@gmail.com', N'Số 1 Xuân Đỉnh, Bắc Từ Liêm, Hà Nội', 0348573567, 'HaiAnh', 3846520, null, null, '04/27/2020'),
							 (00017, N'Đào Xuân Hương', 'daoxuanhuong1989@gmail.com', N'phường Trung Hoà, quận Cầu Giấy, Hà Nội', 0350011567, 'DaoHuong', 2384234, null, null,'04/28/2020'),
							 (00018, N'Nguyễn Phương Thảo', 'thobeo1982@gmail.com', N'Nghĩa Đô, Quận Cầu Giấy, Thành phố Hà Nội, Việt Nam', 0352078567, 'ThoBeo', 12345678, null, null, '04/28/2020'),
							 (00019, N'Nguyễn Văn Tuấn', 'nguyenvantuan1978@gmail.com', N'Trần Duy Hưng, Cầu Giấy, Hà Nội', 0350986567, 'TuanNguyenVan', 12345678, null, null, '04/29/2020'),
							 (00020, N'Lê Thu Hiền', 'thuhien1997@gmail.com', N'Trần Hưng Đạo, Hoàn Kiếm, Hà Nội', 0309343567, 'ThuHien', 128642, null, null, '04/29/2020')

INSERT INTO DANHMUC VALUES (01, N'Quần áo cho bé trai'),
                           (02, N'Quần áo cho bé gái'),
						   (03, N'Quần áo cho trẻ sơ sinh')

INSERT INTO DANHMUCSANPHAM VALUES (001, 01, N'Quần bé trai'),
                                  (002, 01, N'Áo bé trai'),
								  (003, 01, N'Bộ quần áo bé trai'),
								  (004, 02, N'Quần bé gái'),
                                  (005, 02, N'Áo bé gái'),
								  (006, 02, N'Bộ quần áo bé gái'),
								  (007, 03, N'Quần trẻ sơ sinh'),
                                  (008, 03, N'Áo trẻ sơ sinh'),
								  (009, 03, N'Bộ quần áo trẻ sơ sinh')

INSERT INTO TRANGTHAIDONHANG VALUES (1, N'Đang xử lý'),
                             (2, N'Đang giao'),
							 (3, N'Đã giao hàng')
							 
INSERT INTO DONHANG VALUES ('DH00001', 01, 00001, 3, 150000, '04/04/2020', '04/05/2020', '04/05/2020', null),
                           ('DH00002', 01, 00002, 3, 169000, '04/04/2020', '04/05/2020', '04/05/2020', null),
						   ('DH00003', 02, 00003, 3, 200000, '04/05/2020', '04/06/2020', '04/06/2020', null),
						   ('DH00004', 03, 00004, 3, 300000, '04/05/2020', '04/06/2020', '04/06/2020', null),
						   ('DH00005', 05, 00005, 3, 150000, '04/05/2020', '04/06/2020', '04/06/2020', null),
						   ('DH00006', 01, 00006, 3, 150000, '04/05/2020', '04/06/2020', '04/06/2020', null),
						   ('DH00007', 02, 00007, 3, 200000, '04/06/2020', '04/07/2020', '04/07/2020', null),
						   ('DH00008', 01, 00008, 3, 300000, '04/06/2020', '04/07/2020', '04/07/2020', null),
						   ('DH00009', 03, 00009, 3, 200000, '04/15/2020', '04/16/2020', '04/16/2020', null),
						   ('DH00010', 01, 00010, 3, 150000, '04/20/2020', '04/21/2020', '04/21/2020', null),
						   ('DH00011', 01, 00011, 3, 200000, '04/20/2020', '04/21/2020', '04/21/2020', null),
						   ('DH00012', 05, 00012, 3, 150000, '04/22/2020', '04/23/2020', '04/23/2020', null),
						   ('DH00013', 04, 00013, 3, 300000, '04/25/2020', '04/24/2020', '04/24/2020', null),
						   ('DH00014', 03, 00014, 3, 150000, '04/25/2020', '04/24/2020', '04/24/2020', null),
						   ('DH00015', 04, 00015, 3, 150000, '04/26/2020', '04/27/2020', '04/27/2020', null),
						   ('DH00016', 05, 00016, 3, 200000, '04/27/2020', '04/28/2020', '04/28/2020', null),
						   ('DH00017', 02, 00017, 3, 300000, '04/28/2020', '04/29/2020', '04/29/2020', null),
						   ('DH00018', 01, 00018, 3, 200000, '04/28/2020', '04/29/2020', '04/29/2020', null),
						   ('DH00019', 02, 00019, 3, 200000, '04/29/2020', '04/30/2020', '04/30/2020', null),
						   ('DH00020', 01, 00020, 3, 200000, '04/29/2020', '04/30/2020', '04/30/2020', null)

INSERT INTO KichCo VALUES (1, 'S'),
                          (2, 'M'),
						  (3, 'L'),
						  (4, 'FreeSize')

INSERT INTO ThuongHieu VALUES (1, N'Bò Sữa', N'Thanh Xuân, Hà Nội', 0354053097),
                              (2, N'Adidas', N'362 Đỗ Xuân Hợp, Phước Long A, Q9', 0906393561),
							  (3, N'Nike', N'362 Đỗ Xuân Hợp, Phước Long A, Q9, tp Hồ Chí Minh', 0368185590)

INSERT INTO ChatLieu VALUES (1, 'Coton'),
                            (2, 'KaKi'),
							(3, 'Jeans'),
							(4, 'Lanh')

INSERT INTO SANPHAM VALUES  ('SP001', 005, 1, 1, 1,  N'ÁO PHÔNG BÉ GÁI HỌA TIẾT', 150000, 150000, 10, N'https://canifa.s3.amazonaws.com/media/catalog/product/1/t/1ts19s005-fo025-120_2.jpg', N'https://canifa.s3.amazonaws.com/media/catalog/product/1/t/1ts19s005-fo025-120_2.jpg',
                            N'Áo phông cotton USA họa tiết.Dáng regular, cổ tròn, ngắn tay.Phù hợp mặc mùa hè, thoải mái, dễ dàng. Kết hợp quần shorts, giày thể thao, sandal.', '01/15/2020', 1),
							
                          ('SP002', 005, 1,1,1, N'ÁO PHÔNG BÉ GÁI', 169000, 169000,10, N'https://canifa.s3.amazonaws.com/media/catalog/product/1/t/1ts20s006-sb287-1-thumb.jpg', N'https://canifa.s3.amazonaws.com/media/catalog/product/1/t/1ts20s006-sb287-1-thumb.jpg',
                            N'Áo phông in hình chất liệu cottonPhom regular, cổ tròn, tay cộc.', '01/15/2020', 3),
							('SP003', 005, 1, 1, 1, N'ÁO PHÔNG BÉ GÁI', 169000, 169000,10, N'https://canifa.s3.amazonaws.com/media/catalog/product/1/t/1ts20s027-sg0921-_01.jpg',  N'https://canifa.s3.amazonaws.com/media/catalog/product/1/t/1ts20s027-sg0921-_01.jpg', 
							N'Áo phông chất liệu cotton in hình thân trước.
                            Phom regular, cổ tròn, tay cộc.Phù hợp mùa xuân hè. Phong cách đơn giản, dễ dàng kết hợp với quần soóc, jeans, khaki,…','01/15/2020', 3),

							('SP004', 004,1, 2, 2, N'QUẦN VÁY BÉ GÁI', 350000, 350000, 10, N'https://canifa.s3.amazonaws.com/media/catalog/product/1/k/1ks19s012-sa403-120_2.jpg',  N'https://canifa.s3.amazonaws.com/media/catalog/product/1/k/1ks19s012-sa403-120_2.jpg',
							N'Chân váy cotton 
                            Phom chữ A, cạp rời (thân trước êm, thân sau luồn chun) thắt nơ trang trí, túi ốp thân trước.
                            Phù hợp mặc mùa xuân hè, thoải mái, dễ dàng. Kết hợp áo phông, áo blouse, sandal.', '01/15/2020', 1),
							('SP005', 004,1, 2, 3, N'QUẦN VÁY BÉ GÁI', 350000, 350000,10, N'https://canifa.s3.amazonaws.com/media/catalog/product/1/k/1ks20s006-sb205-110.jpg',N'https://canifa.s3.amazonaws.com/media/catalog/product/1/k/1ks20s006-sb205-110.jpg',
							N'Chân váy chất liệu polyester. Phom regular, dáng xoè, có lót.', '01/15/2020', 1),

							('SP006', 006, 1,1,1, N'VÁY LIỀN BÉ GÁI', 290000,290000,10, N'https://canifa.s3.amazonaws.com/media/catalog/product/1/d/1ds20s025-pr091-2-thumb.jpg',  N'https://canifa.s3.amazonaws.com/media/catalog/product/1/d/1ds20s025-pr091-2-thumb.jpg',
							N'Váy liền bé gái', '01/15/2020', 1),

							('SP007', 001,2,3,3, N'QUẦN BÉ TRAI', 200000,200000,10, N'https://canifa.s3.amazonaws.com/media/catalog/product/2/b/2bk20s002-se219-2.jpg',N'https://canifa.s3.amazonaws.com/media/catalog/product/2/b/2bk20s002-se219-2.jpg',
							N'Quần khaki trơn, chất liệu khaki vân chéo cotton spandex co giãn. Phom regular, dáng dài. Cạp chun, dây luồn cạp. Túi dọc thân. Đơn giản, thoải mái, phù hợp nhiều hoàn cảnh. Thích hợp mặc quanh năm. Kết hợp với áo phông, sơ mi…với sandal, giày thể thao...','01/15/2020',1),
							('SP008', 001,2,3,3, N'QUẦN JEANS BÉ TRAI', 300000, 300000,10, N'https://canifa.s3.amazonaws.com/media/catalog/product/2/b/2bj20s001-sj556-120.jpg', N'https://canifa.s3.amazonaws.com/media/catalog/product/2/b/2bj20s001-sj556-120.jpg',
							N'Quần jeans trơn, chất liệu denim cotton pha. Phom regular, dáng dài. Túi chéo. Cạp chun, dây luồn cạp.', '01/15/2020', 1),
							('SP009', 002,3,1,1, N'ÁO BÉ TRAI', 150000, 150000,10, N'https://canifa.s3.amazonaws.com/media/catalog/product/2/t/2th20s002-cg068-120.jpg', N'https://canifa.s3.amazonaws.com/media/catalog/product/2/t/2th20s002-cg068-120.jpg',
							N'Áo sơ mi cotton họa tiết kẻ caro. Phom regular, cổ đức cài khuy, tay cộc.', '01/15/2020', 1),
							('SP010', 003,2,4,1, N'BỘ MẶC NHÀ BÉ TRAI', 299000,299000,10, N'https://canifa.s3.amazonaws.com/media/catalog/product/2/l/2ls20s014-sg052-1-thumb.jpg', N'https://canifa.s3.amazonaws.com/media/catalog/product/2/l/2ls20s014-sg052-1-thumb.jpg',
							N'Bộ mặc nhà cotton họa tiết. Phom regular, áo cộc tay, quần cộc.', '01/15/2020', 1),

							('SP011', 009,2,1,1, N'COMBO BỘ LIỀN', 200000,200000,10, N'https://canifa.s3.amazonaws.com/media/catalog/product/7/l/7lj18a006-pm026-9-12-ghep_final_2.jpg',N'https://canifa.s3.amazonaws.com/media/catalog/product/7/l/7lj18a006-pm026-9-12-ghep_final_2.jpg',
							N'Combo bộ liền cho bé', '01/15/2020', 1),
							('SP012', 008,2,1,2, N'COMBO ÁO BÉ', 150000,150000,10, N'https://canifa.s3.amazonaws.com/media/catalog/product/7/s/7st18a002-fw103-69-ghep_final.jpg',N'https://canifa.s3.amazonaws.com/media/catalog/product/7/s/7st18a002-fw103-69-ghep_final.jpg',
							N'Set áo mặc nhà bé cổ tròn có 2 khuy bấm ở vai để mẹ dễ dàng thay, mặc áo cho bé
                            Chất liệu mềm mại, thấm hút mồ hôi tốt giúp bé luôn có được cảm giác thoải mái, dễ chịu
                            Sản phẩm sử dụng chất liệu Cotton US đạt chứng chỉ - OEKOTEX Class 1 an toàn tuyệt đối cho sức khỏe của em bé Sản phẩm dành cho cả em bé trai và em bé gái', '01/15/2020', 2),
							('SP013', 007, 2,1,3,N'QUẦN BÉ SƠ SINH', 200000, 200000, 10, N'https://canifa.s3.amazonaws.com/media/catalog/product/7/l/7lb18s003-sb440-69.jpg',  N'https://canifa.s3.amazonaws.com/media/catalog/product/7/l/7lb18s003-sb440-69.jpg',
							N'Quần đùi đũng rộng bé trai
                            Quần dáng thụng với đũng quần sâu, rộng rãi tạo sự thoải mái trong từng vận động
                            Thiết kế cạp bo chun co giãn ôm vừa vặn, không gây in hằn sâu làm tổn thương da bé, không bị tuột khi bé cử động.
                            Chất liệu 100 % Cotton US mang lại cảm giác mềm mại, thấm hút mồ hôi tốt giúp bé luôn có được cảm giác thoải mái, dễ chịu.
                            Sản phẩm đạt chứng chỉ - OEKOTEX Class 1 an toàn cho làn da nhạy cảm của bé', '01/15/2020', 2)

INSERT INTO CHITIETDONHANG VALUES ('CT0001', 'DH00001', 'SP001', 1, 150000, NULL),
                                  ('CT0002', 'DH00002', 'SP002', 1, 169000, NULL),
								  ('CT0003', 'DH00003', 'SP007', 1, 200000, NULL),
								  ('CT0004', 'DH00004', 'SP008', 1, 300000, NULL),
								  ('CT0005', 'DH00005', 'SP009', 1, 150000, NULL),
								  ('CT0006', 'DH00006', 'SP012', 1, 150000, NULL),
								  ('CT0007', 'DH00007', 'SP011', 1, 200000, NULL),
								  ('CT0008', 'DH00008', 'SP012', 1, 150000, NULL),
								  ('CT0009', 'DH00008', 'SP001', 1, 150000, NULL),
								  ('CT0010', 'DH00009', 'SP007', 1, 200000, NULL),
								  ('CT0011', 'DH00010', 'SP009', 1, 150000, NULL),
								  ('CT0012', 'DH00011', 'SP013', 1, 200000, NULL),
								  ('CT0013', 'DH00012', 'SP012', 1, 150000, NULL),
								  ('CT0014', 'DH00013', 'SP008', 1, 300000, NULL),
								  ('CT0015', 'DH00014', 'SP001', 1, 150000, NULL),
								  ('CT0016', 'DH00015', 'SP001', 1, 150000, NULL),
								  ('CT0017', 'DH00016', 'SP011', 1, 200000, NULL),
								  ('CT0018', 'DH00017', 'SP008', 1, 300000, NULL),
								  ('CT0019', 'DH00018', 'SP011', 1, 200000, NULL),
								  ('CT0020', 'DH00019', 'SP011', 1, 200000, NULL),
								  ('CT0021', 'DH00020', 'SP011', 1, 200000, NULL)