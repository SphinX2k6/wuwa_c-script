using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000C0C RID: 3084
	[UnrealObjectPath("/Script/Engine.GpuNpcSimpleEdit")]
	[UnrealStructLayout(1096, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1096)]
	public class AGpuNpcSimpleEdit : AActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06009B57 RID: 39767 RVA: 0x000DCB87 File Offset: 0x000DAD87
		public new static UClassStackOnlyPtr StaticClass()
		{
			return AGpuNpcSimpleEdit._ClassPtr;
		}

		// Token: 0x06009B58 RID: 39768 RVA: 0x000DCB94 File Offset: 0x000DAD94
		public AGpuNpcSimpleEdit() : this(BuiltinUtils.AllocNativeUObject(AGpuNpcSimpleEdit.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06009B59 RID: 39769 RVA: 0x000DCBBC File Offset: 0x000DADBC
		[NullableContext(1)]
		public AGpuNpcSimpleEdit(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(AGpuNpcSimpleEdit.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170024ED RID: 9453
		// (get) Token: 0x06009B5A RID: 39770 RVA: 0x000DCBEF File Offset: 0x000DADEF
		// (set) Token: 0x06009B5B RID: 39771 RVA: 0x000DCBFF File Offset: 0x000DADFF
		public unsafe int GroupIndex
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AGpuNpcSimpleEdit.__PropertyOffset_GroupIndex);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AGpuNpcSimpleEdit.__PropertyOffset_GroupIndex) = value;
			}
		}

		// Token: 0x170024EE RID: 9454
		// (get) Token: 0x06009B5C RID: 39772 RVA: 0x000DCC10 File Offset: 0x000DAE10
		// (set) Token: 0x06009B5D RID: 39773 RVA: 0x000DCC24 File Offset: 0x000DAE24
		public unsafe FGuid SlotGuid
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AGpuNpcSimpleEdit.__PropertyOffset_SlotGuid);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AGpuNpcSimpleEdit.__PropertyOffset_SlotGuid) = value;
			}
		}

		// Token: 0x170024EF RID: 9455
		// (get) Token: 0x06009B5E RID: 39774 RVA: 0x000DCC39 File Offset: 0x000DAE39
		// (set) Token: 0x06009B5F RID: 39775 RVA: 0x000DCC49 File Offset: 0x000DAE49
		public unsafe int GpuAnimIndex
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AGpuNpcSimpleEdit.__PropertyOffset_GpuAnimIndex);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AGpuNpcSimpleEdit.__PropertyOffset_GpuAnimIndex) = value;
			}
		}

		// Token: 0x06009B60 RID: 39776 RVA: 0x000DCC5A File Offset: 0x000DAE5A
		public void SetGpuAnimIndex(int InAnimIndex)
		{
			AGpuNpcSimpleEdit.__SetGpuAnimIndex_Internal(base.NativePtr, InAnimIndex);
		}

		// Token: 0x06009B61 RID: 39777
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetGpuAnimIndex_Internal(IntPtr @this, int InAnimIndex);

		// Token: 0x06009B62 RID: 39778 RVA: 0x000DCC68 File Offset: 0x000DAE68
		static AGpuNpcSimpleEdit()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.GpuNpcSimpleEdit");
		}

		// Token: 0x06009B63 RID: 39779 RVA: 0x000DCC76 File Offset: 0x000DAE76
		protected AGpuNpcSimpleEdit(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040055BE RID: 21950
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.GpuNpcSimpleEdit";

		// Token: 0x040055BF RID: 21951
		private static IntPtr _ClassPtr;

		// Token: 0x040055C0 RID: 21952
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040055C1 RID: 21953
		internal static int __PropertyOffset_GroupIndex;

		// Token: 0x040055C2 RID: 21954
		internal static int __PropertyOffset_SlotGuid;

		// Token: 0x040055C3 RID: 21955
		internal static int __PropertyOffset_GpuAnimIndex;
	}
}
