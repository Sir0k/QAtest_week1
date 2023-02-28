namespace QAtest_week1
{
    public class Calculation
    {
        public static int GetQuantityForProduct(int count, int width, int length, int productType, int materialType)
        {
            // Проверяем является ли count, width, length положительным числом больше нуля
            if (count <= 0 || width <= 0 || length <= 0)
            {
                return -1;
            }

            if (productType == 0) { }

            // Выбираем коэффициент в зависимости от типа продукции
            double сoefficient;
            switch (productType)
            {
                case 1:
                    сoefficient = 1.1;
                    break;
                case 2:
                    сoefficient = 2.5;
                    break;
                case 3:
                    сoefficient = 8.43;
                    break;
                default:
                    return -1;
            }

            // Выбираем процент брака в зависимости от типа материала
            double wastePercentage;
            switch (materialType)
            {
                case 1:
                    wastePercentage = 0.003;
                    break;
                case 2:
                    wastePercentage = 0.0012;
                    break;
                default:
                    return -1;
            }
            // Рассчитываем количество необходимого качественного сырья ;
            double totalArea = width * length * count;

            // Учитываем возможный брак материала и округляем до ближайшего целого
            double totalMaterials = totalArea * сoefficient / (1 - wastePercentage);
            return (int)Math.Ceiling(totalMaterials);
        }

    }
}