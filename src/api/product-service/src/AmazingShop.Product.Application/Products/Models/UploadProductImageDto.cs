namespace AmazingShop.Product.Application.Product.Dto
{
    public class UploadProductImageDto : BaseResponseDto<string>
    {
        public static UploadProductImageDto Create(string filePath)
        {
            return new UploadProductImageDto() { Payload = filePath };
        }
    }
}