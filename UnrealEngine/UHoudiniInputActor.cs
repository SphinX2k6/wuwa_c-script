using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020014C9 RID: 5321
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/HoudiniEngineRuntime.HoudiniInputActor")]
	[UnrealStructLayout(352, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 352)]
	public class UHoudiniInputActor : UHoudiniInputObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060134AF RID: 79023 RVA: 0x001C5E13 File Offset: 0x001C4013
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UHoudiniInputActor._ClassPtr;
		}

		// Token: 0x060134B0 RID: 79024 RVA: 0x001C5E20 File Offset: 0x001C4020
		public UHoudiniInputActor() : this(BuiltinUtils.AllocNativeUObject(UHoudiniInputActor.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060134B1 RID: 79025 RVA: 0x001C5E48 File Offset: 0x001C4048
		public UHoudiniInputActor(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UHoudiniInputActor.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17004B33 RID: 19251
		// (get) Token: 0x060134B2 RID: 79026 RVA: 0x001C5E7C File Offset: 0x001C407C
		// (set) Token: 0x060134B3 RID: 79027 RVA: 0x001C5EB5 File Offset: 0x001C40B5
		public TArray<UHoudiniInputSceneComponent> ActorComponents
		{
			get
			{
				base.FastCheckIsValid();
				TArray<UHoudiniInputSceneComponent> result;
				if ((result = this._ActorComponents) == null)
				{
					result = (this._ActorComponents = new TArray<UHoudiniInputSceneComponent>(base.NativePtr + (IntPtr)UHoudiniInputActor.__PropertyOffset_ActorComponents, this));
				}
				return result;
			}
			set
			{
				this.ActorComponents.CopyAssign(value);
			}
		}

		// Token: 0x17004B34 RID: 19252
		// (get) Token: 0x060134B4 RID: 79028 RVA: 0x001C5EC4 File Offset: 0x001C40C4
		// (set) Token: 0x060134B5 RID: 79029 RVA: 0x001C5EFD File Offset: 0x001C40FD
		public TSet<TSoftObjectPtr<UObject>> ActorSceneComponents
		{
			get
			{
				base.FastCheckIsValid();
				TSet<TSoftObjectPtr<UObject>> result;
				if ((result = this._ActorSceneComponents) == null)
				{
					result = (this._ActorSceneComponents = new TSet<TSoftObjectPtr<UObject>>(base.NativePtr + (IntPtr)UHoudiniInputActor.__PropertyOffset_ActorSceneComponents, this));
				}
				return result;
			}
			set
			{
				this.ActorSceneComponents.CopyAssign(value);
			}
		}

		// Token: 0x17004B35 RID: 19253
		// (get) Token: 0x060134B6 RID: 79030 RVA: 0x001C5F0B File Offset: 0x001C410B
		// (set) Token: 0x060134B7 RID: 79031 RVA: 0x001C5F1B File Offset: 0x001C411B
		public unsafe int LastUpdateNumComponentsAdded
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UHoudiniInputActor.__PropertyOffset_LastUpdateNumComponentsAdded);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UHoudiniInputActor.__PropertyOffset_LastUpdateNumComponentsAdded) = value;
			}
		}

		// Token: 0x17004B36 RID: 19254
		// (get) Token: 0x060134B8 RID: 79032 RVA: 0x001C5F2C File Offset: 0x001C412C
		// (set) Token: 0x060134B9 RID: 79033 RVA: 0x001C5F3C File Offset: 0x001C413C
		public unsafe int LastUpdateNumComponentsRemoved
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UHoudiniInputActor.__PropertyOffset_LastUpdateNumComponentsRemoved);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UHoudiniInputActor.__PropertyOffset_LastUpdateNumComponentsRemoved) = value;
			}
		}

		// Token: 0x060134BA RID: 79034 RVA: 0x001C5F4D File Offset: 0x001C414D
		static UHoudiniInputActor()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/HoudiniEngineRuntime.HoudiniInputActor");
		}

		// Token: 0x060134BB RID: 79035 RVA: 0x001C5F5B File Offset: 0x001C415B
		protected UHoudiniInputActor(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400A6B6 RID: 42678
		public new const string __ObjectPath = "/Script/HoudiniEngineRuntime.HoudiniInputActor";

		// Token: 0x0400A6B7 RID: 42679
		private static IntPtr _ClassPtr;

		// Token: 0x0400A6B8 RID: 42680
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400A6B9 RID: 42681
		internal static int __PropertyOffset_ActorComponents;

		// Token: 0x0400A6BA RID: 42682
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UHoudiniInputSceneComponent> _ActorComponents;

		// Token: 0x0400A6BB RID: 42683
		internal static int __PropertyOffset_ActorSceneComponents;

		// Token: 0x0400A6BC RID: 42684
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private TSet<TSoftObjectPtr<UObject>> _ActorSceneComponents;

		// Token: 0x0400A6BD RID: 42685
		internal static int __PropertyOffset_LastUpdateNumComponentsAdded;

		// Token: 0x0400A6BE RID: 42686
		internal static int __PropertyOffset_LastUpdateNumComponentsRemoved;
	}
}
