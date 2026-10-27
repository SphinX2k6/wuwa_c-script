using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020004C8 RID: 1224
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/ControlRig.ControlRigGizmoLibrary")]
	[UnrealStructLayout(256, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 256)]
	public class UControlRigGizmoLibrary : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060041E3 RID: 16867 RVA: 0x000628DB File Offset: 0x00060ADB
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UControlRigGizmoLibrary._ClassPtr;
		}

		// Token: 0x060041E4 RID: 16868 RVA: 0x000628E8 File Offset: 0x00060AE8
		public UControlRigGizmoLibrary() : this(BuiltinUtils.AllocNativeUObject(UControlRigGizmoLibrary.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060041E5 RID: 16869 RVA: 0x00062910 File Offset: 0x00060B10
		public UControlRigGizmoLibrary(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UControlRigGizmoLibrary.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17001007 RID: 4103
		// (get) Token: 0x060041E6 RID: 16870 RVA: 0x00062944 File Offset: 0x00060B44
		// (set) Token: 0x060041E7 RID: 16871 RVA: 0x0006297D File Offset: 0x00060B7D
		public FControlRigGizmoDefinition DefaultGizmo
		{
			get
			{
				base.FastCheckIsValid();
				FControlRigGizmoDefinition result;
				if ((result = this._DefaultGizmo) == null)
				{
					result = (this._DefaultGizmo = new FControlRigGizmoDefinition(base.NativePtr + (IntPtr)UControlRigGizmoLibrary.__PropertyOffset_DefaultGizmo, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FControlRigGizmoDefinition.StaticStruct(), base.NativePtr + (IntPtr)UControlRigGizmoLibrary.__PropertyOffset_DefaultGizmo, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17001008 RID: 4104
		// (get) Token: 0x060041E8 RID: 16872 RVA: 0x0006299E File Offset: 0x00060B9E
		// (set) Token: 0x060041E9 RID: 16873 RVA: 0x000629B3 File Offset: 0x00060BB3
		public TSoftObjectPtr<UMaterial> DefaultMaterial
		{
			get
			{
				return new TSoftObjectPtr<UMaterial>(base.NativePtr + (IntPtr)UControlRigGizmoLibrary.__PropertyOffset_DefaultMaterial, this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)UControlRigGizmoLibrary.__PropertyOffset_DefaultMaterial, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x17001009 RID: 4105
		// (get) Token: 0x060041EA RID: 16874 RVA: 0x000629D8 File Offset: 0x00060BD8
		// (set) Token: 0x060041EB RID: 16875 RVA: 0x000629EC File Offset: 0x00060BEC
		public unsafe FName MaterialColorParameter
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UControlRigGizmoLibrary.__PropertyOffset_MaterialColorParameter);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UControlRigGizmoLibrary.__PropertyOffset_MaterialColorParameter) = value;
			}
		}

		// Token: 0x1700100A RID: 4106
		// (get) Token: 0x060041EC RID: 16876 RVA: 0x00062A04 File Offset: 0x00060C04
		// (set) Token: 0x060041ED RID: 16877 RVA: 0x00062A3D File Offset: 0x00060C3D
		public TArray<FControlRigGizmoDefinition> Gizmos
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FControlRigGizmoDefinition> result;
				if ((result = this._Gizmos) == null)
				{
					result = (this._Gizmos = new TArray<FControlRigGizmoDefinition>(base.NativePtr + (IntPtr)UControlRigGizmoLibrary.__PropertyOffset_Gizmos, this));
				}
				return result;
			}
			set
			{
				this.Gizmos.CopyAssign(value);
			}
		}

		// Token: 0x060041EE RID: 16878 RVA: 0x00062A4B File Offset: 0x00060C4B
		static UControlRigGizmoLibrary()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/ControlRig.ControlRigGizmoLibrary");
		}

		// Token: 0x060041EF RID: 16879 RVA: 0x00062A59 File Offset: 0x00060C59
		protected UControlRigGizmoLibrary(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04001F4D RID: 8013
		public new const string __ObjectPath = "/Script/ControlRig.ControlRigGizmoLibrary";

		// Token: 0x04001F4E RID: 8014
		private static IntPtr _ClassPtr;

		// Token: 0x04001F4F RID: 8015
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04001F50 RID: 8016
		internal static int __PropertyOffset_DefaultGizmo;

		// Token: 0x04001F51 RID: 8017
		[Nullable(2)]
		private FControlRigGizmoDefinition _DefaultGizmo;

		// Token: 0x04001F52 RID: 8018
		internal static int __PropertyOffset_DefaultMaterial;

		// Token: 0x04001F53 RID: 8019
		internal static int __PropertyOffset_MaterialColorParameter;

		// Token: 0x04001F54 RID: 8020
		internal static int __PropertyOffset_Gizmos;

		// Token: 0x04001F55 RID: 8021
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FControlRigGizmoDefinition> _Gizmos;
	}
}
