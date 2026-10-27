using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020007EB RID: 2027
	[UnrealObjectPath("/Script/Engine.AnimBlueprint")]
	[UnrealStructLayout(1448, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1448)]
	public class UAnimBlueprint : UBlueprint, IUnrealUObject, IUnrealObject, IInterface_PreviewMeshProvider, IUnrealNativeInterface, IUnrealInterface
	{
		// Token: 0x06006C25 RID: 27685 RVA: 0x0009B858 File Offset: 0x00099A58
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UAnimBlueprint._ClassPtr;
		}

		// Token: 0x06006C26 RID: 27686 RVA: 0x0009B864 File Offset: 0x00099A64
		int IInterface_PreviewMeshProvider.InterfaceOffset()
		{
			return UAnimBlueprint.__InterfaceOffset_IInterface_PreviewMeshProvider;
		}

		// Token: 0x06006C27 RID: 27687 RVA: 0x0009B86C File Offset: 0x00099A6C
		public UAnimBlueprint() : this(BuiltinUtils.AllocNativeUObject(UAnimBlueprint.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06006C28 RID: 27688 RVA: 0x0009B894 File Offset: 0x00099A94
		[NullableContext(1)]
		public UAnimBlueprint(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UAnimBlueprint.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700197C RID: 6524
		// (get) Token: 0x06006C29 RID: 27689 RVA: 0x0009B8C7 File Offset: 0x00099AC7
		// (set) Token: 0x06006C2A RID: 27690 RVA: 0x0009B8DB File Offset: 0x00099ADB
		[Nullable(2)]
		public unsafe USkeleton TargetSkeleton
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USkeleton>(base.NativePtr / (IntPtr)sizeof(void*) + UAnimBlueprint.__PropertyOffset_TargetSkeleton);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UAnimBlueprint.__PropertyOffset_TargetSkeleton, value);
			}
		}

		// Token: 0x1700197D RID: 6525
		// (get) Token: 0x06006C2B RID: 27691 RVA: 0x0009B8F0 File Offset: 0x00099AF0
		// (set) Token: 0x06006C2C RID: 27692 RVA: 0x0009B929 File Offset: 0x00099B29
		[Nullable(1)]
		public TArray<FAnimGroupInfo> Groups
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<FAnimGroupInfo> result;
				if ((result = this._Groups) == null)
				{
					result = (this._Groups = new TArray<FAnimGroupInfo>(base.NativePtr + (IntPtr)UAnimBlueprint.__PropertyOffset_Groups, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.Groups.CopyAssign(value);
			}
		}

		// Token: 0x1700197E RID: 6526
		// (get) Token: 0x06006C2D RID: 27693 RVA: 0x0009B937 File Offset: 0x00099B37
		// (set) Token: 0x06006C2E RID: 27694 RVA: 0x0009B947 File Offset: 0x00099B47
		public unsafe bool bUseMultiThreadedAnimationUpdate
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAnimBlueprint.__PropertyOffset_bUseMultiThreadedAnimationUpdate) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAnimBlueprint.__PropertyOffset_bUseMultiThreadedAnimationUpdate) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700197F RID: 6527
		// (get) Token: 0x06006C2F RID: 27695 RVA: 0x0009B958 File Offset: 0x00099B58
		// (set) Token: 0x06006C30 RID: 27696 RVA: 0x0009B968 File Offset: 0x00099B68
		public unsafe bool bWarnAboutBlueprintUsage
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAnimBlueprint.__PropertyOffset_bWarnAboutBlueprintUsage) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAnimBlueprint.__PropertyOffset_bWarnAboutBlueprintUsage) = (value ? 1 : 0);
			}
		}

		// Token: 0x06006C31 RID: 27697 RVA: 0x0009B979 File Offset: 0x00099B79
		static UAnimBlueprint()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.AnimBlueprint");
		}

		// Token: 0x06006C32 RID: 27698 RVA: 0x0009B987 File Offset: 0x00099B87
		protected UAnimBlueprint(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04003408 RID: 13320
		internal static int __InterfaceOffset_IInterface_PreviewMeshProvider;

		// Token: 0x04003409 RID: 13321
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.AnimBlueprint";

		// Token: 0x0400340A RID: 13322
		private static IntPtr _ClassPtr;

		// Token: 0x0400340B RID: 13323
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400340C RID: 13324
		internal static int __PropertyOffset_TargetSkeleton;

		// Token: 0x0400340D RID: 13325
		internal static int __PropertyOffset_Groups;

		// Token: 0x0400340E RID: 13326
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FAnimGroupInfo> _Groups;

		// Token: 0x0400340F RID: 13327
		internal static int __PropertyOffset_bUseMultiThreadedAnimationUpdate;

		// Token: 0x04003410 RID: 13328
		internal static int __PropertyOffset_bWarnAboutBlueprintUsage;
	}
}
