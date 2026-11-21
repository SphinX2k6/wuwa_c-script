using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020006E4 RID: 1764
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/LGUI.UI2DLineRaw")]
	[UnrealStructLayout(2288, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 2288)]
	public class UUI2DLineRaw : UUI2DLineRendererBase, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060095BD RID: 38333 RVA: 0x000E2237 File Offset: 0x000E0437
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UUI2DLineRaw._ClassPtr;
		}

		// Token: 0x060095BE RID: 38334 RVA: 0x000E2244 File Offset: 0x000E0444
		public UUI2DLineRaw() : this(BuiltinUtils.AllocNativeUObject(UUI2DLineRaw.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060095BF RID: 38335 RVA: 0x000E226C File Offset: 0x000E046C
		public UUI2DLineRaw(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UUI2DLineRaw.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17001BCC RID: 7116
		// (get) Token: 0x060095C0 RID: 38336 RVA: 0x000E22A0 File Offset: 0x000E04A0
		// (set) Token: 0x060095C1 RID: 38337 RVA: 0x000E22D9 File Offset: 0x000E04D9
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

		// Token: 0x060095C2 RID: 38338 RVA: 0x000E22E7 File Offset: 0x000E04E7
		[NullableContext(2)]
		public void SetVertsData(ULGUIVertsData InVertsData)
		{
			UUI2DLineRaw.__SetVertsData_Internal(base.NativePtr, (InVertsData != null) ? InVertsData.NativePtr : IntPtr.Zero);
		}

		// Token: 0x060095C3 RID: 38339 RVA: 0x000E2304 File Offset: 0x000E0504
		[NullableContext(2)]
		public void SetPoints(in TArray<FVector2D> InPoints, bool bAdjustSize = false)
		{
			UUI2DLineRaw.__SetPoints_Internal(base.NativePtr, (InPoints ?? new TArray<FVector2D>()).NativePtr, bAdjustSize);
		}

		// Token: 0x060095C4 RID: 38340 RVA: 0x000E2322 File Offset: 0x000E0522
		public void AdjustSize()
		{
			UUI2DLineRaw.__AdjustSize_Internal(base.NativePtr);
		}

		// Token: 0x060095C5 RID: 38341
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetVertsData_Internal(IntPtr @this, IntPtr InVertsData);

		// Token: 0x060095C6 RID: 38342
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetPoints_Internal(IntPtr @this, IntPtr InPoints, bool bAdjustSize);

		// Token: 0x060095C7 RID: 38343
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __AdjustSize_Internal(IntPtr @this);

		// Token: 0x060095C8 RID: 38344 RVA: 0x000E232F File Offset: 0x000E052F
		static UUI2DLineRaw()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/LGUI.UI2DLineRaw");
		}

		// Token: 0x060095C9 RID: 38345 RVA: 0x000E233D File Offset: 0x000E053D
		protected UUI2DLineRaw(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04004129 RID: 16681
		public new const string __ObjectPath = "/Script/LGUI.UI2DLineRaw";

		// Token: 0x0400412A RID: 16682
		private static IntPtr _ClassPtr;

		// Token: 0x0400412B RID: 16683
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400412C RID: 16684
		internal static int __PropertyOffset_PointArray;

		// Token: 0x0400412D RID: 16685
		[Nullable(2)]
		private TArray<FVector2D> _PointArray;
	}
}
