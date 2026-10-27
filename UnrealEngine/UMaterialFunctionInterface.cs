using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000E83 RID: 3715
	[UnrealObjectPath("/Script/Engine.MaterialFunctionInterface")]
	[UnrealStructLayout(88, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 88)]
	public class UMaterialFunctionInterface : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600C667 RID: 50791 RVA: 0x0011F7A6 File Offset: 0x0011D9A6
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMaterialFunctionInterface._ClassPtr;
		}

		// Token: 0x0600C668 RID: 50792 RVA: 0x0011F7B4 File Offset: 0x0011D9B4
		public UMaterialFunctionInterface() : this(BuiltinUtils.AllocNativeUObject(UMaterialFunctionInterface.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600C669 RID: 50793 RVA: 0x0011F7DC File Offset: 0x0011D9DC
		[NullableContext(1)]
		public UMaterialFunctionInterface(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMaterialFunctionInterface.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17002E0F RID: 11791
		// (get) Token: 0x0600C66A RID: 50794 RVA: 0x0011F80F File Offset: 0x0011DA0F
		// (set) Token: 0x0600C66B RID: 50795 RVA: 0x0011F823 File Offset: 0x0011DA23
		public unsafe FGuid StateId
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UMaterialFunctionInterface.__PropertyOffset_StateId);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMaterialFunctionInterface.__PropertyOffset_StateId) = value;
			}
		}

		// Token: 0x17002E10 RID: 11792
		// (get) Token: 0x0600C66C RID: 50796 RVA: 0x0011F838 File Offset: 0x0011DA38
		// (set) Token: 0x0600C66D RID: 50797 RVA: 0x0011F848 File Offset: 0x0011DA48
		public unsafe EMaterialFunctionUsage MaterialFunctionUsage
		{
			get
			{
				return (EMaterialFunctionUsage)(*(base.NativePtr + (IntPtr)UMaterialFunctionInterface.__PropertyOffset_MaterialFunctionUsage));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMaterialFunctionInterface.__PropertyOffset_MaterialFunctionUsage) = (byte)value;
			}
		}

		// Token: 0x0600C66E RID: 50798 RVA: 0x0011F859 File Offset: 0x0011DA59
		static UMaterialFunctionInterface()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.MaterialFunctionInterface");
		}

		// Token: 0x0600C66F RID: 50799 RVA: 0x0011F867 File Offset: 0x0011DA67
		protected UMaterialFunctionInterface(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04006A3A RID: 27194
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.MaterialFunctionInterface";

		// Token: 0x04006A3B RID: 27195
		private static IntPtr _ClassPtr;

		// Token: 0x04006A3C RID: 27196
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04006A3D RID: 27197
		internal static int __PropertyOffset_StateId;

		// Token: 0x04006A3E RID: 27198
		internal static int __PropertyOffset_MaterialFunctionUsage;
	}
}
