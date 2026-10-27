using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020014D3 RID: 5331
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/HoudiniEngineRuntime.HoudiniInputInstancedMeshComponent")]
	[UnrealStructLayout(368, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 368)]
	public class UHoudiniInputInstancedMeshComponent : UHoudiniInputMeshComponent, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601350F RID: 79119 RVA: 0x001C66DE File Offset: 0x001C48DE
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UHoudiniInputInstancedMeshComponent._ClassPtr;
		}

		// Token: 0x06013510 RID: 79120 RVA: 0x001C66EC File Offset: 0x001C48EC
		public UHoudiniInputInstancedMeshComponent() : this(BuiltinUtils.AllocNativeUObject(UHoudiniInputInstancedMeshComponent.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06013511 RID: 79121 RVA: 0x001C6714 File Offset: 0x001C4914
		public UHoudiniInputInstancedMeshComponent(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UHoudiniInputInstancedMeshComponent.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17004B4A RID: 19274
		// (get) Token: 0x06013512 RID: 79122 RVA: 0x001C6748 File Offset: 0x001C4948
		// (set) Token: 0x06013513 RID: 79123 RVA: 0x001C6781 File Offset: 0x001C4981
		public TArray<FTransform> InstanceTransforms
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FTransform> result;
				if ((result = this._InstanceTransforms) == null)
				{
					result = (this._InstanceTransforms = new TArray<FTransform>(base.NativePtr + (IntPtr)UHoudiniInputInstancedMeshComponent.__PropertyOffset_InstanceTransforms, this));
				}
				return result;
			}
			set
			{
				this.InstanceTransforms.CopyAssign(value);
			}
		}

		// Token: 0x06013514 RID: 79124 RVA: 0x001C678F File Offset: 0x001C498F
		static UHoudiniInputInstancedMeshComponent()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/HoudiniEngineRuntime.HoudiniInputInstancedMeshComponent");
		}

		// Token: 0x06013515 RID: 79125 RVA: 0x001C679D File Offset: 0x001C499D
		protected UHoudiniInputInstancedMeshComponent(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400A6F0 RID: 42736
		public new const string __ObjectPath = "/Script/HoudiniEngineRuntime.HoudiniInputInstancedMeshComponent";

		// Token: 0x0400A6F1 RID: 42737
		private static IntPtr _ClassPtr;

		// Token: 0x0400A6F2 RID: 42738
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400A6F3 RID: 42739
		internal static int __PropertyOffset_InstanceTransforms;

		// Token: 0x0400A6F4 RID: 42740
		[Nullable(2)]
		private TArray<FTransform> _InstanceTransforms;
	}
}
