using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002975 RID: 10613
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/UMG.GridPanel")]
	[UnrealStructLayout(728, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 728)]
	public class UGridPanel : UPanelWidget, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060273ED RID: 160749 RVA: 0x003BDAB7 File Offset: 0x003BBCB7
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UGridPanel._ClassPtr;
		}

		// Token: 0x060273EE RID: 160750 RVA: 0x003BDAC4 File Offset: 0x003BBCC4
		public UGridPanel() : this(BuiltinUtils.AllocNativeUObject(UGridPanel.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060273EF RID: 160751 RVA: 0x003BDAEC File Offset: 0x003BBCEC
		public UGridPanel(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UGridPanel.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170096E8 RID: 38632
		// (get) Token: 0x060273F0 RID: 160752 RVA: 0x003BDB20 File Offset: 0x003BBD20
		// (set) Token: 0x060273F1 RID: 160753 RVA: 0x003BDB59 File Offset: 0x003BBD59
		public TArray<float> ColumnFill
		{
			get
			{
				base.FastCheckIsValid();
				TArray<float> result;
				if ((result = this._ColumnFill) == null)
				{
					result = (this._ColumnFill = new TArray<float>(base.NativePtr + (IntPtr)UGridPanel.__PropertyOffset_ColumnFill, this));
				}
				return result;
			}
			set
			{
				this.ColumnFill.CopyAssign(value);
			}
		}

		// Token: 0x170096E9 RID: 38633
		// (get) Token: 0x060273F2 RID: 160754 RVA: 0x003BDB68 File Offset: 0x003BBD68
		// (set) Token: 0x060273F3 RID: 160755 RVA: 0x003BDBA1 File Offset: 0x003BBDA1
		public TArray<float> RowFill
		{
			get
			{
				base.FastCheckIsValid();
				TArray<float> result;
				if ((result = this._RowFill) == null)
				{
					result = (this._RowFill = new TArray<float>(base.NativePtr + (IntPtr)UGridPanel.__PropertyOffset_RowFill, this));
				}
				return result;
			}
			set
			{
				this.RowFill.CopyAssign(value);
			}
		}

		// Token: 0x060273F4 RID: 160756 RVA: 0x003BDBAF File Offset: 0x003BBDAF
		public void SetRowFill(int ColumnIndex, float Coefficient)
		{
			UGridPanel.__SetRowFill_Internal(base.NativePtr, ColumnIndex, Coefficient);
		}

		// Token: 0x060273F5 RID: 160757 RVA: 0x003BDBBE File Offset: 0x003BBDBE
		public void SetColumnFill(int ColumnIndex, float Coefficient)
		{
			UGridPanel.__SetColumnFill_Internal(base.NativePtr, ColumnIndex, Coefficient);
		}

		// Token: 0x060273F6 RID: 160758 RVA: 0x003BDBCD File Offset: 0x003BBDCD
		[NullableContext(2)]
		public UGridSlot AddChildToGrid(UWidget Content, int InRow = 0, int InColumn = 0)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UGridSlot>(UGridPanel.__AddChildToGrid_Internal(base.NativePtr, (Content != null) ? Content.NativePtr : IntPtr.Zero, InRow, InColumn));
		}

		// Token: 0x060273F7 RID: 160759
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetRowFill_Internal(IntPtr @this, int ColumnIndex, float Coefficient);

		// Token: 0x060273F8 RID: 160760
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetColumnFill_Internal(IntPtr @this, int ColumnIndex, float Coefficient);

		// Token: 0x060273F9 RID: 160761
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __AddChildToGrid_Internal(IntPtr @this, IntPtr Content, int InRow, int InColumn);

		// Token: 0x060273FA RID: 160762 RVA: 0x003BDBF1 File Offset: 0x003BBDF1
		static UGridPanel()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/UMG.GridPanel");
		}

		// Token: 0x060273FB RID: 160763 RVA: 0x003BDBFF File Offset: 0x003BBDFF
		protected UGridPanel(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04015905 RID: 88325
		public new const string __ObjectPath = "/Script/UMG.GridPanel";

		// Token: 0x04015906 RID: 88326
		private static IntPtr _ClassPtr;

		// Token: 0x04015907 RID: 88327
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04015908 RID: 88328
		internal static int __PropertyOffset_ColumnFill;

		// Token: 0x04015909 RID: 88329
		[Nullable(2)]
		private TArray<float> _ColumnFill;

		// Token: 0x0401590A RID: 88330
		internal static int __PropertyOffset_RowFill;

		// Token: 0x0401590B RID: 88331
		[Nullable(2)]
		private TArray<float> _RowFill;
	}
}
