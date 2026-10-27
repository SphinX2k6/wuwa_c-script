using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200015C RID: 348
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/AIModule.BTTask_PlayAnimation")]
	[UnrealStructLayout(200, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 200)]
	public class UBTTask_PlayAnimation : UBTTaskNode, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060017DA RID: 6106 RVA: 0x000231F5 File Offset: 0x000213F5
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UBTTask_PlayAnimation._ClassPtr;
		}

		// Token: 0x060017DB RID: 6107 RVA: 0x00023204 File Offset: 0x00021404
		public UBTTask_PlayAnimation() : this(BuiltinUtils.AllocNativeUObject(UBTTask_PlayAnimation.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060017DC RID: 6108 RVA: 0x0002322C File Offset: 0x0002142C
		[NullableContext(1)]
		public UBTTask_PlayAnimation(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UBTTask_PlayAnimation.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700061D RID: 1565
		// (get) Token: 0x060017DD RID: 6109 RVA: 0x0002325F File Offset: 0x0002145F
		// (set) Token: 0x060017DE RID: 6110 RVA: 0x00023273 File Offset: 0x00021473
		public unsafe UAnimationAsset AnimationToPlay
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UAnimationAsset>(base.NativePtr / (IntPtr)sizeof(void*) + UBTTask_PlayAnimation.__PropertyOffset_AnimationToPlay);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UBTTask_PlayAnimation.__PropertyOffset_AnimationToPlay, value);
			}
		}

		// Token: 0x1700061E RID: 1566
		// (get) Token: 0x060017DF RID: 6111 RVA: 0x00023288 File Offset: 0x00021488
		// (set) Token: 0x060017E0 RID: 6112 RVA: 0x000232A1 File Offset: 0x000214A1
		public unsafe bool bLooping
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UBTTask_PlayAnimation.__PropertyOffset_bLooping) & UBTTask_PlayAnimation.__PropertyMask_bLooping) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UBTTask_PlayAnimation.__PropertyOffset_bLooping) = ((*(base.NativePtr + (IntPtr)UBTTask_PlayAnimation.__PropertyOffset_bLooping) & ~UBTTask_PlayAnimation.__PropertyMask_bLooping) | (value ? UBTTask_PlayAnimation.__PropertyMask_bLooping : 0));
			}
		}

		// Token: 0x1700061F RID: 1567
		// (get) Token: 0x060017E1 RID: 6113 RVA: 0x000232D1 File Offset: 0x000214D1
		// (set) Token: 0x060017E2 RID: 6114 RVA: 0x000232EA File Offset: 0x000214EA
		public unsafe bool bNonBlocking
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UBTTask_PlayAnimation.__PropertyOffset_bNonBlocking) & UBTTask_PlayAnimation.__PropertyMask_bNonBlocking) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UBTTask_PlayAnimation.__PropertyOffset_bNonBlocking) = ((*(base.NativePtr + (IntPtr)UBTTask_PlayAnimation.__PropertyOffset_bNonBlocking) & ~UBTTask_PlayAnimation.__PropertyMask_bNonBlocking) | (value ? UBTTask_PlayAnimation.__PropertyMask_bNonBlocking : 0));
			}
		}

		// Token: 0x17000620 RID: 1568
		// (get) Token: 0x060017E3 RID: 6115 RVA: 0x0002331A File Offset: 0x0002151A
		// (set) Token: 0x060017E4 RID: 6116 RVA: 0x0002332E File Offset: 0x0002152E
		public unsafe UBehaviorTreeComponent MyOwnerComp
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UBehaviorTreeComponent>(base.NativePtr / (IntPtr)sizeof(void*) + UBTTask_PlayAnimation.__PropertyOffset_MyOwnerComp);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UBTTask_PlayAnimation.__PropertyOffset_MyOwnerComp, value);
			}
		}

		// Token: 0x17000621 RID: 1569
		// (get) Token: 0x060017E5 RID: 6117 RVA: 0x00023343 File Offset: 0x00021543
		// (set) Token: 0x060017E6 RID: 6118 RVA: 0x00023357 File Offset: 0x00021557
		public unsafe USkeletalMeshComponent CachedSkelMesh
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USkeletalMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + UBTTask_PlayAnimation.__PropertyOffset_CachedSkelMesh);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UBTTask_PlayAnimation.__PropertyOffset_CachedSkelMesh, value);
			}
		}

		// Token: 0x060017E7 RID: 6119 RVA: 0x0002336C File Offset: 0x0002156C
		static UBTTask_PlayAnimation()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/AIModule.BTTask_PlayAnimation");
		}

		// Token: 0x060017E8 RID: 6120 RVA: 0x0002337A File Offset: 0x0002157A
		protected UBTTask_PlayAnimation(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040005D0 RID: 1488
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/AIModule.BTTask_PlayAnimation";

		// Token: 0x040005D1 RID: 1489
		private static IntPtr _ClassPtr;

		// Token: 0x040005D2 RID: 1490
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040005D3 RID: 1491
		internal static int __PropertyOffset_AnimationToPlay;

		// Token: 0x040005D4 RID: 1492
		internal static int __PropertyOffset_bLooping;

		// Token: 0x040005D5 RID: 1493
		internal static byte __PropertyMask_bLooping;

		// Token: 0x040005D6 RID: 1494
		internal static int __PropertyOffset_bNonBlocking;

		// Token: 0x040005D7 RID: 1495
		internal static byte __PropertyMask_bNonBlocking;

		// Token: 0x040005D8 RID: 1496
		internal static int __PropertyOffset_MyOwnerComp;

		// Token: 0x040005D9 RID: 1497
		internal static int __PropertyOffset_CachedSkelMesh;
	}
}
