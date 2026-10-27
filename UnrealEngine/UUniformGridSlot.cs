using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020029E9 RID: 10729
	[UnrealObjectPath("/Script/UMG.UniformGridSlot")]
	[UnrealStructLayout(88, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 88)]
	public class UUniformGridSlot : UPanelSlot, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06027BF2 RID: 162802 RVA: 0x003C9663 File Offset: 0x003C7863
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UUniformGridSlot._ClassPtr;
		}

		// Token: 0x06027BF3 RID: 162803 RVA: 0x003C9670 File Offset: 0x003C7870
		public UUniformGridSlot() : this(BuiltinUtils.AllocNativeUObject(UUniformGridSlot.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06027BF4 RID: 162804 RVA: 0x003C9698 File Offset: 0x003C7898
		[NullableContext(1)]
		public UUniformGridSlot(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UUniformGridSlot.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17009843 RID: 38979
		// (get) Token: 0x06027BF5 RID: 162805 RVA: 0x003C96CB File Offset: 0x003C78CB
		// (set) Token: 0x06027BF6 RID: 162806 RVA: 0x003C96DF File Offset: 0x003C78DF
		public unsafe TEnumAsByte<EHorizontalAlignment> HorizontalAlignment
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UUniformGridSlot.__PropertyOffset_HorizontalAlignment);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUniformGridSlot.__PropertyOffset_HorizontalAlignment) = value;
			}
		}

		// Token: 0x17009844 RID: 38980
		// (get) Token: 0x06027BF7 RID: 162807 RVA: 0x003C96F4 File Offset: 0x003C78F4
		// (set) Token: 0x06027BF8 RID: 162808 RVA: 0x003C9708 File Offset: 0x003C7908
		public unsafe TEnumAsByte<EVerticalAlignment> VerticalAlignment
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UUniformGridSlot.__PropertyOffset_VerticalAlignment);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUniformGridSlot.__PropertyOffset_VerticalAlignment) = value;
			}
		}

		// Token: 0x17009845 RID: 38981
		// (get) Token: 0x06027BF9 RID: 162809 RVA: 0x003C971D File Offset: 0x003C791D
		// (set) Token: 0x06027BFA RID: 162810 RVA: 0x003C972D File Offset: 0x003C792D
		public unsafe int Row
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UUniformGridSlot.__PropertyOffset_Row);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUniformGridSlot.__PropertyOffset_Row) = value;
			}
		}

		// Token: 0x17009846 RID: 38982
		// (get) Token: 0x06027BFB RID: 162811 RVA: 0x003C973E File Offset: 0x003C793E
		// (set) Token: 0x06027BFC RID: 162812 RVA: 0x003C974E File Offset: 0x003C794E
		public unsafe int Column
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UUniformGridSlot.__PropertyOffset_Column);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUniformGridSlot.__PropertyOffset_Column) = value;
			}
		}

		// Token: 0x06027BFD RID: 162813 RVA: 0x003C975F File Offset: 0x003C795F
		public void SetVerticalAlignment(EVerticalAlignment InVerticalAlignment)
		{
			UUniformGridSlot.__SetVerticalAlignment_Internal(base.NativePtr, InVerticalAlignment);
		}

		// Token: 0x06027BFE RID: 162814 RVA: 0x003C9772 File Offset: 0x003C7972
		public void SetRow(int InRow)
		{
			UUniformGridSlot.__SetRow_Internal(base.NativePtr, InRow);
		}

		// Token: 0x06027BFF RID: 162815 RVA: 0x003C9780 File Offset: 0x003C7980
		public void SetHorizontalAlignment(EHorizontalAlignment InHorizontalAlignment)
		{
			UUniformGridSlot.__SetHorizontalAlignment_Internal(base.NativePtr, InHorizontalAlignment);
		}

		// Token: 0x06027C00 RID: 162816 RVA: 0x003C9793 File Offset: 0x003C7993
		public void SetColumn(int InColumn)
		{
			UUniformGridSlot.__SetColumn_Internal(base.NativePtr, InColumn);
		}

		// Token: 0x06027C01 RID: 162817
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetVerticalAlignment_Internal(IntPtr @this, TEnumAsByte<EVerticalAlignment> InVerticalAlignment);

		// Token: 0x06027C02 RID: 162818
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetRow_Internal(IntPtr @this, int InRow);

		// Token: 0x06027C03 RID: 162819
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetHorizontalAlignment_Internal(IntPtr @this, TEnumAsByte<EHorizontalAlignment> InHorizontalAlignment);

		// Token: 0x06027C04 RID: 162820
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetColumn_Internal(IntPtr @this, int InColumn);

		// Token: 0x06027C05 RID: 162821 RVA: 0x003C97A1 File Offset: 0x003C79A1
		static UUniformGridSlot()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/UMG.UniformGridSlot");
		}

		// Token: 0x06027C06 RID: 162822 RVA: 0x003C97AF File Offset: 0x003C79AF
		protected UUniformGridSlot(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04015C2A RID: 89130
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/UMG.UniformGridSlot";

		// Token: 0x04015C2B RID: 89131
		private static IntPtr _ClassPtr;

		// Token: 0x04015C2C RID: 89132
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04015C2D RID: 89133
		internal static int __PropertyOffset_HorizontalAlignment;

		// Token: 0x04015C2E RID: 89134
		internal static int __PropertyOffset_VerticalAlignment;

		// Token: 0x04015C2F RID: 89135
		internal static int __PropertyOffset_Row;

		// Token: 0x04015C30 RID: 89136
		internal static int __PropertyOffset_Column;
	}
}
