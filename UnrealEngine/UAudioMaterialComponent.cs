using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020024B8 RID: 9400
	[UnrealObjectPath("/Script/NavmeshPartition.AudioMaterialComponent")]
	[UnrealStructLayout(592, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 592)]
	public class UAudioMaterialComponent : USceneComponent, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06023337 RID: 144183 RVA: 0x003411AE File Offset: 0x0033F3AE
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UAudioMaterialComponent._ClassPtr;
		}

		// Token: 0x06023338 RID: 144184 RVA: 0x003411BC File Offset: 0x0033F3BC
		public UAudioMaterialComponent() : this(BuiltinUtils.AllocNativeUObject(UAudioMaterialComponent.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06023339 RID: 144185 RVA: 0x003411E4 File Offset: 0x0033F3E4
		[NullableContext(1)]
		public UAudioMaterialComponent(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UAudioMaterialComponent.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0602333A RID: 144186 RVA: 0x00341217 File Offset: 0x0033F417
		static UAudioMaterialComponent()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/NavmeshPartition.AudioMaterialComponent");
		}

		// Token: 0x0602333B RID: 144187 RVA: 0x00341225 File Offset: 0x0033F425
		protected UAudioMaterialComponent(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04012CCB RID: 77003
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/NavmeshPartition.AudioMaterialComponent";

		// Token: 0x04012CCC RID: 77004
		private static IntPtr _ClassPtr;

		// Token: 0x04012CCD RID: 77005
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
