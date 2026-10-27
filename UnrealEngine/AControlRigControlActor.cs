using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020004C1 RID: 1217
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/ControlRig.ControlRigControlActor")]
	[UnrealStructLayout(1192, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1192)]
	public class AControlRigControlActor : AActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06004150 RID: 16720 RVA: 0x00061DD8 File Offset: 0x0005FFD8
		public new static UClassStackOnlyPtr StaticClass()
		{
			return AControlRigControlActor._ClassPtr;
		}

		// Token: 0x06004151 RID: 16721 RVA: 0x00061DE4 File Offset: 0x0005FFE4
		public AControlRigControlActor() : this(BuiltinUtils.AllocNativeUObject(AControlRigControlActor.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06004152 RID: 16722 RVA: 0x00061E0C File Offset: 0x0006000C
		public AControlRigControlActor(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(AControlRigControlActor.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17000FE6 RID: 4070
		// (get) Token: 0x06004153 RID: 16723 RVA: 0x00061E3F File Offset: 0x0006003F
		// (set) Token: 0x06004154 RID: 16724 RVA: 0x00061E53 File Offset: 0x00060053
		[Nullable(2)]
		public unsafe AActor ActorToTrack
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<AActor>(base.NativePtr / (IntPtr)sizeof(void*) + AControlRigControlActor.__PropertyOffset_ActorToTrack);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + AControlRigControlActor.__PropertyOffset_ActorToTrack, value);
			}
		}

		// Token: 0x17000FE7 RID: 4071
		// (get) Token: 0x06004155 RID: 16725 RVA: 0x00061E68 File Offset: 0x00060068
		// (set) Token: 0x06004156 RID: 16726 RVA: 0x00061E7C File Offset: 0x0006007C
		[Nullable(new byte[]
		{
			0,
			1
		})]
		public unsafe TSubclassOf<UControlRig> ControlRigClass
		{
			[return: Nullable(new byte[]
			{
				0,
				1
			})]
			get
			{
				return *(base.NativePtr + (IntPtr)AControlRigControlActor.__PropertyOffset_ControlRigClass);
			}
			[param: Nullable(new byte[]
			{
				0,
				1
			})]
			set
			{
				*(base.NativePtr + (IntPtr)AControlRigControlActor.__PropertyOffset_ControlRigClass) = value;
			}
		}

		// Token: 0x17000FE8 RID: 4072
		// (get) Token: 0x06004157 RID: 16727 RVA: 0x00061E91 File Offset: 0x00060091
		// (set) Token: 0x06004158 RID: 16728 RVA: 0x00061EA1 File Offset: 0x000600A1
		public unsafe bool bRefreshOnTick
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AControlRigControlActor.__PropertyOffset_bRefreshOnTick) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)AControlRigControlActor.__PropertyOffset_bRefreshOnTick) = (value ? 1 : 0);
			}
		}

		// Token: 0x17000FE9 RID: 4073
		// (get) Token: 0x06004159 RID: 16729 RVA: 0x00061EB2 File Offset: 0x000600B2
		// (set) Token: 0x0600415A RID: 16730 RVA: 0x00061EC2 File Offset: 0x000600C2
		public unsafe bool bIsSelectable
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AControlRigControlActor.__PropertyOffset_bIsSelectable) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)AControlRigControlActor.__PropertyOffset_bIsSelectable) = (value ? 1 : 0);
			}
		}

		// Token: 0x17000FEA RID: 4074
		// (get) Token: 0x0600415B RID: 16731 RVA: 0x00061ED3 File Offset: 0x000600D3
		// (set) Token: 0x0600415C RID: 16732 RVA: 0x00061EE7 File Offset: 0x000600E7
		[Nullable(2)]
		public unsafe UMaterialInterface MaterialOverride
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInterface>(base.NativePtr / (IntPtr)sizeof(void*) + AControlRigControlActor.__PropertyOffset_MaterialOverride);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + AControlRigControlActor.__PropertyOffset_MaterialOverride, value);
			}
		}

		// Token: 0x17000FEB RID: 4075
		// (get) Token: 0x0600415D RID: 16733 RVA: 0x00061EFC File Offset: 0x000600FC
		// (set) Token: 0x0600415E RID: 16734 RVA: 0x00061F10 File Offset: 0x00060110
		public unsafe string ColorParameter
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)AControlRigControlActor.__PropertyOffset_ColorParameter)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)AControlRigControlActor.__PropertyOffset_ColorParameter)), value);
			}
		}

		// Token: 0x17000FEC RID: 4076
		// (get) Token: 0x0600415F RID: 16735 RVA: 0x00061F25 File Offset: 0x00060125
		// (set) Token: 0x06004160 RID: 16736 RVA: 0x00061F35 File Offset: 0x00060135
		public unsafe bool bCastShadows
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AControlRigControlActor.__PropertyOffset_bCastShadows) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)AControlRigControlActor.__PropertyOffset_bCastShadows) = (value ? 1 : 0);
			}
		}

		// Token: 0x17000FED RID: 4077
		// (get) Token: 0x06004161 RID: 16737 RVA: 0x00061F46 File Offset: 0x00060146
		// (set) Token: 0x06004162 RID: 16738 RVA: 0x00061F5A File Offset: 0x0006015A
		[Nullable(2)]
		public unsafe USceneComponent ActorRootComponent
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + AControlRigControlActor.__PropertyOffset_ActorRootComponent);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + AControlRigControlActor.__PropertyOffset_ActorRootComponent, value);
			}
		}

		// Token: 0x17000FEE RID: 4078
		// (get) Token: 0x06004163 RID: 16739 RVA: 0x00061F6F File Offset: 0x0006016F
		// (set) Token: 0x06004164 RID: 16740 RVA: 0x00061F83 File Offset: 0x00060183
		[Nullable(2)]
		public unsafe UControlRig ControlRig
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UControlRig>(base.NativePtr / (IntPtr)sizeof(void*) + AControlRigControlActor.__PropertyOffset_ControlRig);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + AControlRigControlActor.__PropertyOffset_ControlRig, value);
			}
		}

		// Token: 0x17000FEF RID: 4079
		// (get) Token: 0x06004165 RID: 16741 RVA: 0x00061F98 File Offset: 0x00060198
		// (set) Token: 0x06004166 RID: 16742 RVA: 0x00061FD1 File Offset: 0x000601D1
		public TArray<FName> ControlNames
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FName> result;
				if ((result = this._ControlNames) == null)
				{
					result = (this._ControlNames = new TArray<FName>(base.NativePtr + (IntPtr)AControlRigControlActor.__PropertyOffset_ControlNames, this));
				}
				return result;
			}
			set
			{
				this.ControlNames.CopyAssign(value);
			}
		}

		// Token: 0x17000FF0 RID: 4080
		// (get) Token: 0x06004167 RID: 16743 RVA: 0x00061FE0 File Offset: 0x000601E0
		// (set) Token: 0x06004168 RID: 16744 RVA: 0x00062019 File Offset: 0x00060219
		public TArray<FTransform> GizmoTransforms
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FTransform> result;
				if ((result = this._GizmoTransforms) == null)
				{
					result = (this._GizmoTransforms = new TArray<FTransform>(base.NativePtr + (IntPtr)AControlRigControlActor.__PropertyOffset_GizmoTransforms, this));
				}
				return result;
			}
			set
			{
				this.GizmoTransforms.CopyAssign(value);
			}
		}

		// Token: 0x17000FF1 RID: 4081
		// (get) Token: 0x06004169 RID: 16745 RVA: 0x00062028 File Offset: 0x00060228
		// (set) Token: 0x0600416A RID: 16746 RVA: 0x00062061 File Offset: 0x00060261
		public TArray<UStaticMeshComponent> Components
		{
			get
			{
				base.FastCheckIsValid();
				TArray<UStaticMeshComponent> result;
				if ((result = this._Components) == null)
				{
					result = (this._Components = new TArray<UStaticMeshComponent>(base.NativePtr + (IntPtr)AControlRigControlActor.__PropertyOffset_Components, this));
				}
				return result;
			}
			set
			{
				this.Components.CopyAssign(value);
			}
		}

		// Token: 0x17000FF2 RID: 4082
		// (get) Token: 0x0600416B RID: 16747 RVA: 0x00062070 File Offset: 0x00060270
		// (set) Token: 0x0600416C RID: 16748 RVA: 0x000620A9 File Offset: 0x000602A9
		public TArray<UMaterialInstanceDynamic> Materials
		{
			get
			{
				base.FastCheckIsValid();
				TArray<UMaterialInstanceDynamic> result;
				if ((result = this._Materials) == null)
				{
					result = (this._Materials = new TArray<UMaterialInstanceDynamic>(base.NativePtr + (IntPtr)AControlRigControlActor.__PropertyOffset_Materials, this));
				}
				return result;
			}
			set
			{
				this.Materials.CopyAssign(value);
			}
		}

		// Token: 0x17000FF3 RID: 4083
		// (get) Token: 0x0600416D RID: 16749 RVA: 0x000620B7 File Offset: 0x000602B7
		// (set) Token: 0x0600416E RID: 16750 RVA: 0x000620CB File Offset: 0x000602CB
		public unsafe FName ColorParameterName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AControlRigControlActor.__PropertyOffset_ColorParameterName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AControlRigControlActor.__PropertyOffset_ColorParameterName) = value;
			}
		}

		// Token: 0x0600416F RID: 16751 RVA: 0x000620E0 File Offset: 0x000602E0
		public void Refresh()
		{
			AControlRigControlActor.__Refresh_Internal(base.NativePtr);
		}

		// Token: 0x06004170 RID: 16752 RVA: 0x000620ED File Offset: 0x000602ED
		public void Clear()
		{
			AControlRigControlActor.__Clear_Internal(base.NativePtr);
		}

		// Token: 0x06004171 RID: 16753
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __Refresh_Internal(IntPtr @this);

		// Token: 0x06004172 RID: 16754
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __Clear_Internal(IntPtr @this);

		// Token: 0x06004173 RID: 16755 RVA: 0x000620FA File Offset: 0x000602FA
		static AControlRigControlActor()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/ControlRig.ControlRigControlActor");
		}

		// Token: 0x06004174 RID: 16756 RVA: 0x00062108 File Offset: 0x00060308
		protected AControlRigControlActor(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04001F12 RID: 7954
		public new const string __ObjectPath = "/Script/ControlRig.ControlRigControlActor";

		// Token: 0x04001F13 RID: 7955
		private static IntPtr _ClassPtr;

		// Token: 0x04001F14 RID: 7956
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04001F15 RID: 7957
		internal static int __PropertyOffset_ActorToTrack;

		// Token: 0x04001F16 RID: 7958
		internal static int __PropertyOffset_ControlRigClass;

		// Token: 0x04001F17 RID: 7959
		internal static int __PropertyOffset_bRefreshOnTick;

		// Token: 0x04001F18 RID: 7960
		internal static int __PropertyOffset_bIsSelectable;

		// Token: 0x04001F19 RID: 7961
		internal static int __PropertyOffset_MaterialOverride;

		// Token: 0x04001F1A RID: 7962
		internal static int __PropertyOffset_ColorParameter;

		// Token: 0x04001F1B RID: 7963
		internal static int __PropertyOffset_bCastShadows;

		// Token: 0x04001F1C RID: 7964
		internal static int __PropertyOffset_ActorRootComponent;

		// Token: 0x04001F1D RID: 7965
		internal static int __PropertyOffset_ControlRig;

		// Token: 0x04001F1E RID: 7966
		internal static int __PropertyOffset_ControlNames;

		// Token: 0x04001F1F RID: 7967
		[Nullable(2)]
		private TArray<FName> _ControlNames;

		// Token: 0x04001F20 RID: 7968
		internal static int __PropertyOffset_GizmoTransforms;

		// Token: 0x04001F21 RID: 7969
		[Nullable(2)]
		private TArray<FTransform> _GizmoTransforms;

		// Token: 0x04001F22 RID: 7970
		internal static int __PropertyOffset_Components;

		// Token: 0x04001F23 RID: 7971
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UStaticMeshComponent> _Components;

		// Token: 0x04001F24 RID: 7972
		internal static int __PropertyOffset_Materials;

		// Token: 0x04001F25 RID: 7973
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UMaterialInstanceDynamic> _Materials;

		// Token: 0x04001F26 RID: 7974
		internal static int __PropertyOffset_ColorParameterName;
	}
}
