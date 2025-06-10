using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiApp001.Models
{
    public class TodoItem
    {
        [Key]
        public int Id { get; set; }

        [Required]  // NotNull 일경우는 string에 ?(nullable) 를 삭제할 것
        [Column(TypeName = "VARCHAR(100)")] // 이거 사용안하면 테이블 컬럼이 LONGTEXT로 생성됨
        public string Title { get; set; }

        [Required]
        [Column(TypeName = "CHAR(8)")] // 20250610 날짜
        public string TodoDate { get; set; }

        [Required]
        //[Column(TypeName = "BOOLEAN")]
        public bool IsComplete { get; set; }


    }
}
