using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020021B6 RID: 8630
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/LGUI.UISpineManager")]
	[UnrealStructLayout(152, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 152)]
	public class UUISpineManager : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06020D3B RID: 134459 RVA: 0x0030810C File Offset: 0x0030630C
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UUISpineManager._ClassPtr;
		}

		// Token: 0x06020D3C RID: 134460 RVA: 0x00308118 File Offset: 0x00306318
		public UUISpineManager() : this(BuiltinUtils.AllocNativeUObject(UUISpineManager.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06020D3D RID: 134461 RVA: 0x00308140 File Offset: 0x00306340
		public UUISpineManager(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UUISpineManager.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17008037 RID: 32823
		// (get) Token: 0x06020D3E RID: 134462 RVA: 0x00308174 File Offset: 0x00306374
		// (set) Token: 0x06020D3F RID: 134463 RVA: 0x003081AD File Offset: 0x003063AD
		public TArray<USpineSkeletonAnimationComponent> SpineSkeletonAnimationComponents
		{
			get
			{
				base.FastCheckIsValid();
				TArray<USpineSkeletonAnimationComponent> result;
				if ((result = this._SpineSkeletonAnimationComponents) == null)
				{
					result = (this._SpineSkeletonAnimationComponents = new TArray<USpineSkeletonAnimationComponent>(base.NativePtr + (IntPtr)UUISpineManager.__PropertyOffset_SpineSkeletonAnimationComponents, this));
				}
				return result;
			}
			set
			{
				this.SpineSkeletonAnimationComponents.CopyAssign(value);
			}
		}

		// Token: 0x17008038 RID: 32824
		// (get) Token: 0x06020D40 RID: 134464 RVA: 0x003081BC File Offset: 0x003063BC
		// (set) Token: 0x06020D41 RID: 134465 RVA: 0x003081F5 File Offset: 0x003063F5
		public TMap<USpineSkeletonAnimationComponent, float> SpinePlayRates
		{
			get
			{
				base.FastCheckIsValid();
				TMap<USpineSkeletonAnimationComponent, float> result;
				if ((result = this._SpinePlayRates) == null)
				{
					result = (this._SpinePlayRates = new TMap<USpineSkeletonAnimationComponent, float>(base.NativePtr + (IntPtr)UUISpineManager.__PropertyOffset_SpinePlayRates, this));
				}
				return result;
			}
			set
			{
				this.SpinePlayRates.CopyAssign(value);
			}
		}

		// Token: 0x06020D42 RID: 134466 RVA: 0x00308203 File Offset: 0x00306403
		public void SetGlobalPlayRate(float NewPlayRate)
		{
			UUISpineManager.__SetGlobalPlayRate_Internal(base.NativePtr, NewPlayRate);
		}

		// Token: 0x06020D43 RID: 134467 RVA: 0x00308211 File Offset: 0x00306411
		public float GetGlobalPlayRate(float NewPlayRate)
		{
			return UUISpineManager.__GetGlobalPlayRate_Internal(base.NativePtr, NewPlayRate);
		}

		// Token: 0x06020D44 RID: 134468
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetGlobalPlayRate_Internal(IntPtr @this, float NewPlayRate);

		// Token: 0x06020D45 RID: 134469
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetGlobalPlayRate_Internal(IntPtr @this, float NewPlayRate);

		// Token: 0x06020D46 RID: 134470 RVA: 0x0030821F File Offset: 0x0030641F
		static UUISpineManager()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/LGUI.UISpineManager");
		}

		// Token: 0x06020D47 RID: 134471 RVA: 0x0030822D File Offset: 0x0030642D
		protected UUISpineManager(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0401188E RID: 71822
		public new const string __ObjectPath = "/Script/LGUI.UISpineManager";

		// Token: 0x0401188F RID: 71823
		private static IntPtr _ClassPtr;

		// Token: 0x04011890 RID: 71824
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04011891 RID: 71825
		internal static int __PropertyOffset_SpineSkeletonAnimationComponents;

		// Token: 0x04011892 RID: 71826
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<USpineSkeletonAnimationComponent> _SpineSkeletonAnimationComponents;

		// Token: 0x04011893 RID: 71827
		internal static int __PropertyOffset_SpinePlayRates;

		// Token: 0x04011894 RID: 71828
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TMap<USpineSkeletonAnimationComponent, float> _SpinePlayRates;
	}
}
