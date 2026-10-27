using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200211C RID: 8476
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/LGUI.UI2DLineRaw")]
	[UnrealStructLayout(2288, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 2288)]
	public class UUI2DLineRaw : UUI2DLineRendererBase, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601FE30 RID: 130608 RVA: 0x002F717F File Offset: 0x002F537F
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UUI2DLineRaw._ClassPtr;
		}

		// Token: 0x0601FE31 RID: 130609 RVA: 0x002F718C File Offset: 0x002F538C
		public UUI2DLineRaw() : this(BuiltinUtils.AllocNativeUObject(UUI2DLineRaw.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601FE32 RID: 130610 RVA: 0x002F71B4 File Offset: 0x002F53B4
		public UUI2DLineRaw(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UUI2DLineRaw.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17007D68 RID: 32104
		// (get) Token: 0x0601FE33 RID: 130611 RVA: 0x002F71E8 File Offset: 0x002F53E8
		// (set) Token: 0x0601FE34 RID: 130612 RVA: 0x002F7221 File Offset: 0x002F5421
		public TArray<FVector2D> PointArray
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FVector2D> result;
				if ((result = this._PointArray) == null)
				{
					result = (this._PointArray = new TArray<FVector2D>(base.NativePtr + (IntPtr)UUI2DLineRaw.__PropertyOffset_PointArray, this));
				}
				return result;
			}
			set
			{
				this.PointArray.CopyAssign(value);
			}
		}

		// Token: 0x0601FE35 RID: 130613 RVA: 0x002F722F File Offset: 0x002F542F
		[NullableContext(2)]
		public void SetVertsData(ULGUIVertsData InVertsData)
		{
			UUI2DLineRaw.__SetVertsData_Internal(base.NativePtr, (InVertsData != null) ? InVertsData.NativePtr : IntPtr.Zero);
		}

		// Token: 0x0601FE36 RID: 130614 RVA: 0x002F724C File Offset: 0x002F544C
		[NullableContext(2)]
		public void SetPoints(in TArray<FVector2D> InPoints, bool bAdjustSize = false)
		{
			UUI2DLineRaw.__SetPoints_Internal(base.NativePtr, (InPoints ?? new TArray<FVector2D>()).NativePtr, bAdjustSize);
		}

		// Token: 0x0601FE37 RID: 130615 RVA: 0x002F726A File Offset: 0x002F546A
		public void AdjustSize()
		{
			UUI2DLineRaw.__AdjustSize_Internal(base.NativePtr);
		}

		// Token: 0x0601FE38 RID: 130616
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetVertsData_Internal(IntPtr @this, IntPtr InVertsData);

		// Token: 0x0601FE39 RID: 130617
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetPoints_Internal(IntPtr @this, IntPtr InPoints, bool bAdjustSize);

		// Token: 0x0601FE3A RID: 130618
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __AdjustSize_Internal(IntPtr @this);

		// Token: 0x0601FE3B RID: 130619 RVA: 0x002F7277 File Offset: 0x002F5477
		static UUI2DLineRaw()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/LGUI.UI2DLineRaw");
		}

		// Token: 0x0601FE3C RID: 130620 RVA: 0x002F7285 File Offset: 0x002F5485
		protected UUI2DLineRaw(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040112E8 RID: 70376
		public new const string __ObjectPath = "/Script/LGUI.UI2DLineRaw";

		// Token: 0x040112E9 RID: 70377
		private static IntPtr _ClassPtr;

		// Token: 0x040112EA RID: 70378
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040112EB RID: 70379
		internal static int __PropertyOffset_PointArray;

		// Token: 0x040112EC RID: 70380
		[Nullable(2)]
		private TArray<FVector2D> _PointArray;
	}
}
