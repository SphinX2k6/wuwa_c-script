using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020029C7 RID: 10695
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/UMG.RichImageRow")]
	[UnrealStructLayout(168, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 168)]
	public class FRichImageRow : FTableRowBase, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06027892 RID: 161938 RVA: 0x003C539C File Offset: 0x003C359C
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRichImageRow._ScriptStructPtr != 0) ? FRichImageRow._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/UMG.RichImageRow", ref FRichImageRow._ScriptStructPtr);
		}

		// Token: 0x17009785 RID: 38789
		// (get) Token: 0x06027893 RID: 161939 RVA: 0x003C53C0 File Offset: 0x003C35C0
		// (set) Token: 0x06027894 RID: 161940 RVA: 0x003C5403 File Offset: 0x003C3603
		public FSlateBrush Brush
		{
			get
			{
				base.FastCheckIsValid();
				FSlateBrush result;
				if ((result = this._Brush) == null)
				{
					result = (this._Brush = new FSlateBrush(base.NativePtr + (IntPtr)FRichImageRow.__PropertyOffset_Brush, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FSlateBrush.StaticStruct(), base.NativePtr + (IntPtr)FRichImageRow.__PropertyOffset_Brush, value.NativePtr, 1, false);
			}
		}

		// Token: 0x06027895 RID: 161941 RVA: 0x003C5424 File Offset: 0x003C3624
		public FRichImageRow()
		{
		}

		// Token: 0x06027896 RID: 161942 RVA: 0x003C542C File Offset: 0x003C362C
		public FRichImageRow(FSlateBrush Brush)
		{
			this.Brush = Brush;
		}

		// Token: 0x06027897 RID: 161943 RVA: 0x003C543B File Offset: 0x003C363B
		protected override IntPtr GetUStructPtr()
		{
			return FRichImageRow.StaticStruct();
		}

		// Token: 0x06027898 RID: 161944 RVA: 0x003C5447 File Offset: 0x003C3647
		[NullableContext(2)]
		public FRichImageRow(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06027899 RID: 161945 RVA: 0x003C5451 File Offset: 0x003C3651
		public FRichImageRow(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0602789A RID: 161946 RVA: 0x003C545C File Offset: 0x003C365C
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRichImageRow(Pointer, false, true);
		}

		// Token: 0x0602789B RID: 161947 RVA: 0x003C5466 File Offset: 0x003C3666
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRichImageRow(Pointer, MemoryOwner);
		}

		// Token: 0x04015ACB RID: 88779
		public new const string __ObjectPath = "/Script/UMG.RichImageRow";

		// Token: 0x04015ACC RID: 88780
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04015ACD RID: 88781
		internal static int __PropertyOffset_Brush;

		// Token: 0x04015ACE RID: 88782
		[Nullable(2)]
		private FSlateBrush _Brush;
	}
}
