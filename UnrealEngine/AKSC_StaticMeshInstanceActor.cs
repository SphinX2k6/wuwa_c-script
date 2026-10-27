using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001E56 RID: 7766
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroSimpleCombat.KSC_StaticMeshInstanceActor")]
	[UnrealStructLayout(1600, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1600)]
	public class AKSC_StaticMeshInstanceActor : AActor, IUnrealUObject, IUnrealObject, IKSC_RenderEntityInterface, IUnrealNativeInterface, IUnrealInterface, IKSC_RenderEntityAnimInterface
	{
		// Token: 0x0601D931 RID: 121137 RVA: 0x002BAA40 File Offset: 0x002B8C40
		public new static UClassStackOnlyPtr StaticClass()
		{
			return AKSC_StaticMeshInstanceActor._ClassPtr;
		}

		// Token: 0x0601D932 RID: 121138 RVA: 0x002BAA4C File Offset: 0x002B8C4C
		int IKSC_RenderEntityInterface.InterfaceOffset()
		{
			return AKSC_StaticMeshInstanceActor.__InterfaceOffset_IKSC_RenderEntityInterface;
		}

		// Token: 0x0601D933 RID: 121139 RVA: 0x002BAA53 File Offset: 0x002B8C53
		int IKSC_RenderEntityAnimInterface.InterfaceOffset()
		{
			return AKSC_StaticMeshInstanceActor.__InterfaceOffset_IKSC_RenderEntityAnimInterface;
		}

		// Token: 0x0601D934 RID: 121140 RVA: 0x002BAA5C File Offset: 0x002B8C5C
		public AKSC_StaticMeshInstanceActor() : this(BuiltinUtils.AllocNativeUObject(AKSC_StaticMeshInstanceActor.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601D935 RID: 121141 RVA: 0x002BAA84 File Offset: 0x002B8C84
		public AKSC_StaticMeshInstanceActor(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(AKSC_StaticMeshInstanceActor.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700772B RID: 30507
		// (get) Token: 0x0601D936 RID: 121142 RVA: 0x002BAAB8 File Offset: 0x002B8CB8
		// (set) Token: 0x0601D937 RID: 121143 RVA: 0x002BAAF1 File Offset: 0x002B8CF1
		public TArray<int> RemovedIndices
		{
			get
			{
				base.FastCheckIsValid();
				TArray<int> result;
				if ((result = this._RemovedIndices) == null)
				{
					result = (this._RemovedIndices = new TArray<int>(base.NativePtr + (IntPtr)AKSC_StaticMeshInstanceActor.__PropertyOffset_RemovedIndices, this));
				}
				return result;
			}
			set
			{
				this.RemovedIndices.CopyAssign(value);
			}
		}

		// Token: 0x1700772C RID: 30508
		// (get) Token: 0x0601D938 RID: 121144 RVA: 0x002BAB00 File Offset: 0x002B8D00
		// (set) Token: 0x0601D939 RID: 121145 RVA: 0x002BAB39 File Offset: 0x002B8D39
		public TMap<int, float> DelayRemovedIndices
		{
			get
			{
				base.FastCheckIsValid();
				TMap<int, float> result;
				if ((result = this._DelayRemovedIndices) == null)
				{
					result = (this._DelayRemovedIndices = new TMap<int, float>(base.NativePtr + (IntPtr)AKSC_StaticMeshInstanceActor.__PropertyOffset_DelayRemovedIndices, this));
				}
				return result;
			}
			set
			{
				this.DelayRemovedIndices.CopyAssign(value);
			}
		}

		// Token: 0x1700772D RID: 30509
		// (get) Token: 0x0601D93A RID: 121146 RVA: 0x002BAB48 File Offset: 0x002B8D48
		// (set) Token: 0x0601D93B RID: 121147 RVA: 0x002BAB81 File Offset: 0x002B8D81
		public TArray<int> InstanceAnim
		{
			get
			{
				base.FastCheckIsValid();
				TArray<int> result;
				if ((result = this._InstanceAnim) == null)
				{
					result = (this._InstanceAnim = new TArray<int>(base.NativePtr + (IntPtr)AKSC_StaticMeshInstanceActor.__PropertyOffset_InstanceAnim, this));
				}
				return result;
			}
			set
			{
				this.InstanceAnim.CopyAssign(value);
			}
		}

		// Token: 0x1700772E RID: 30510
		// (get) Token: 0x0601D93C RID: 121148 RVA: 0x002BAB90 File Offset: 0x002B8D90
		// (set) Token: 0x0601D93D RID: 121149 RVA: 0x002BABC9 File Offset: 0x002B8DC9
		public TArray<FTransform> InstanceTransform
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FTransform> result;
				if ((result = this._InstanceTransform) == null)
				{
					result = (this._InstanceTransform = new TArray<FTransform>(base.NativePtr + (IntPtr)AKSC_StaticMeshInstanceActor.__PropertyOffset_InstanceTransform, this));
				}
				return result;
			}
			set
			{
				this.InstanceTransform.CopyAssign(value);
			}
		}

		// Token: 0x1700772F RID: 30511
		// (get) Token: 0x0601D93E RID: 121150 RVA: 0x002BABD8 File Offset: 0x002B8DD8
		// (set) Token: 0x0601D93F RID: 121151 RVA: 0x002BAC11 File Offset: 0x002B8E11
		public TMap<int, int> EntityToInstanceMap
		{
			get
			{
				base.FastCheckIsValid();
				TMap<int, int> result;
				if ((result = this._EntityToInstanceMap) == null)
				{
					result = (this._EntityToInstanceMap = new TMap<int, int>(base.NativePtr + (IntPtr)AKSC_StaticMeshInstanceActor.__PropertyOffset_EntityToInstanceMap, this));
				}
				return result;
			}
			set
			{
				this.EntityToInstanceMap.CopyAssign(value);
			}
		}

		// Token: 0x17007730 RID: 30512
		// (get) Token: 0x0601D940 RID: 121152 RVA: 0x002BAC1F File Offset: 0x002B8E1F
		// (set) Token: 0x0601D941 RID: 121153 RVA: 0x002BAC33 File Offset: 0x002B8E33
		[Nullable(2)]
		public unsafe UInstancedStaticMeshComponent InstancedStaticMeshComponent
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UInstancedStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + AKSC_StaticMeshInstanceActor.__PropertyOffset_InstancedStaticMeshComponent);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + AKSC_StaticMeshInstanceActor.__PropertyOffset_InstancedStaticMeshComponent, value);
			}
		}

		// Token: 0x17007731 RID: 30513
		// (get) Token: 0x0601D942 RID: 121154 RVA: 0x002BAC48 File Offset: 0x002B8E48
		// (set) Token: 0x0601D943 RID: 121155 RVA: 0x002BAC5C File Offset: 0x002B8E5C
		public unsafe FTransform RelativeTrans
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKSC_StaticMeshInstanceActor.__PropertyOffset_RelativeTrans);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKSC_StaticMeshInstanceActor.__PropertyOffset_RelativeTrans) = value;
			}
		}

		// Token: 0x17007732 RID: 30514
		// (get) Token: 0x0601D944 RID: 121156 RVA: 0x002BAC74 File Offset: 0x002B8E74
		// (set) Token: 0x0601D945 RID: 121157 RVA: 0x002BACAD File Offset: 0x002B8EAD
		public TMap<EKSC_GPUNPCAnimState, int> AnimMap
		{
			get
			{
				base.FastCheckIsValid();
				TMap<EKSC_GPUNPCAnimState, int> result;
				if ((result = this._AnimMap) == null)
				{
					result = (this._AnimMap = new TMap<EKSC_GPUNPCAnimState, int>(base.NativePtr + (IntPtr)AKSC_StaticMeshInstanceActor.__PropertyOffset_AnimMap, this));
				}
				return result;
			}
			set
			{
				this.AnimMap.CopyAssign(value);
			}
		}

		// Token: 0x0601D946 RID: 121158 RVA: 0x002BACBB File Offset: 0x002B8EBB
		public virtual void InitRenderActor()
		{
			AKSC_StaticMeshInstanceActor.__InitRenderActor_Internal(base.NativePtr);
		}

		// Token: 0x0601D947 RID: 121159
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __InitRenderActor_Internal(IntPtr @this);

		// Token: 0x0601D948 RID: 121160 RVA: 0x002BACC8 File Offset: 0x002B8EC8
		static AKSC_StaticMeshInstanceActor()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroSimpleCombat.KSC_StaticMeshInstanceActor");
		}

		// Token: 0x0601D949 RID: 121161 RVA: 0x002BACD6 File Offset: 0x002B8ED6
		protected AKSC_StaticMeshInstanceActor(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0401007E RID: 65662
		internal static int __InterfaceOffset_IKSC_RenderEntityInterface;

		// Token: 0x0401007F RID: 65663
		internal static int __InterfaceOffset_IKSC_RenderEntityAnimInterface;

		// Token: 0x04010080 RID: 65664
		public new const string __ObjectPath = "/Script/KuroSimpleCombat.KSC_StaticMeshInstanceActor";

		// Token: 0x04010081 RID: 65665
		private static IntPtr _ClassPtr;

		// Token: 0x04010082 RID: 65666
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04010083 RID: 65667
		internal static int __PropertyOffset_RemovedIndices;

		// Token: 0x04010084 RID: 65668
		[Nullable(2)]
		private TArray<int> _RemovedIndices;

		// Token: 0x04010085 RID: 65669
		internal static int __PropertyOffset_DelayRemovedIndices;

		// Token: 0x04010086 RID: 65670
		[Nullable(2)]
		private TMap<int, float> _DelayRemovedIndices;

		// Token: 0x04010087 RID: 65671
		internal static int __PropertyOffset_InstanceAnim;

		// Token: 0x04010088 RID: 65672
		[Nullable(2)]
		private TArray<int> _InstanceAnim;

		// Token: 0x04010089 RID: 65673
		internal static int __PropertyOffset_InstanceTransform;

		// Token: 0x0401008A RID: 65674
		[Nullable(2)]
		private TArray<FTransform> _InstanceTransform;

		// Token: 0x0401008B RID: 65675
		internal static int __PropertyOffset_EntityToInstanceMap;

		// Token: 0x0401008C RID: 65676
		[Nullable(2)]
		private TMap<int, int> _EntityToInstanceMap;

		// Token: 0x0401008D RID: 65677
		internal static int __PropertyOffset_InstancedStaticMeshComponent;

		// Token: 0x0401008E RID: 65678
		internal static int __PropertyOffset_RelativeTrans;

		// Token: 0x0401008F RID: 65679
		internal static int __PropertyOffset_AnimMap;

		// Token: 0x04010090 RID: 65680
		[Nullable(2)]
		private TMap<EKSC_GPUNPCAnimState, int> _AnimMap;
	}
}
