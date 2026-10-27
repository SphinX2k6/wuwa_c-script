using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020009A4 RID: 2468
	[UnrealObjectPath("/Script/Engine.DebugCameraHUD")]
	[UnrealStructLayout(1280, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1280)]
	public class ADebugCameraHUD : AHUD, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06008B6F RID: 35695 RVA: 0x000C7C76 File Offset: 0x000C5E76
		public new static UClassStackOnlyPtr StaticClass()
		{
			return ADebugCameraHUD._ClassPtr;
		}

		// Token: 0x06008B70 RID: 35696 RVA: 0x000C7C84 File Offset: 0x000C5E84
		public ADebugCameraHUD() : this(BuiltinUtils.AllocNativeUObject(ADebugCameraHUD.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06008B71 RID: 35697 RVA: 0x000C7CAC File Offset: 0x000C5EAC
		[NullableContext(1)]
		public ADebugCameraHUD(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(ADebugCameraHUD.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06008B72 RID: 35698 RVA: 0x000C7CDF File Offset: 0x000C5EDF
		static ADebugCameraHUD()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.DebugCameraHUD");
		}

		// Token: 0x06008B73 RID: 35699 RVA: 0x000C7CED File Offset: 0x000C5EED
		protected ADebugCameraHUD(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400423C RID: 16956
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.DebugCameraHUD";

		// Token: 0x0400423D RID: 16957
		private static IntPtr _ClassPtr;

		// Token: 0x0400423E RID: 16958
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
