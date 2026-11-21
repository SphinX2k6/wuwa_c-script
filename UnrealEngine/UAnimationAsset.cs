using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000175 RID: 373
	[UnrealObjectPath("/Script/Engine.AnimationAsset")]
	[UnrealStructLayout(248, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 248)]
	public abstract class UAnimationAsset : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060016BF RID: 5823 RVA: 0x000237C4 File Offset: 0x000219C4
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UAnimationAsset._ClassPtr;
		}

		// Token: 0x1700025A RID: 602
		// (get) Token: 0x060016C0 RID: 5824 RVA: 0x000237D0 File Offset: 0x000219D0
		// (set) Token: 0x060016C1 RID: 5825 RVA: 0x000237E4 File Offset: 0x000219E4
		[Nullable(2)]
		public unsafe USkeleton Skeleton
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USkeleton>(base.NativePtr / (IntPtr)sizeof(void*) + UAnimationAsset.__PropertyOffset_Skeleton);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UAnimationAsset.__PropertyOffset_Skeleton, value);
			}
		}

		// Token: 0x060016C2 RID: 5826 RVA: 0x000237F9 File Offset: 0x000219F9
		static UAnimationAsset()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.AnimationAsset");
		}

		// Token: 0x060016C3 RID: 5827 RVA: 0x00023808 File Offset: 0x00021A08
		protected UAnimationAsset() : this(BuiltinUtils.AllocNativeUObject(UAnimationAsset.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060016C4 RID: 5828 RVA: 0x00023830 File Offset: 0x00021A30
		protected UAnimationAsset(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400073D RID: 1853
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.AnimationAsset";

		// Token: 0x0400073E RID: 1854
		private static IntPtr _ClassPtr;

		// Token: 0x0400073F RID: 1855
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04000740 RID: 1856
		internal static int __PropertyOffset_Skeleton;
	}
}
