using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020020C8 RID: 8392
	[UnrealObjectPath("/Script/LGUI.LGUISpriteData_BaseImporter")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public class ULGUISpriteData_BaseImporter : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601F9CB RID: 129483 RVA: 0x002F0157 File Offset: 0x002EE357
		public new static UClassStackOnlyPtr StaticClass()
		{
			return ULGUISpriteData_BaseImporter._ClassPtr;
		}

		// Token: 0x0601F9CC RID: 129484 RVA: 0x002F0164 File Offset: 0x002EE364
		public ULGUISpriteData_BaseImporter() : this(BuiltinUtils.AllocNativeUObject(ULGUISpriteData_BaseImporter.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601F9CD RID: 129485 RVA: 0x002F018C File Offset: 0x002EE38C
		[NullableContext(1)]
		public ULGUISpriteData_BaseImporter(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(ULGUISpriteData_BaseImporter.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0601F9CE RID: 129486 RVA: 0x002F01BF File Offset: 0x002EE3BF
		static ULGUISpriteData_BaseImporter()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/LGUI.LGUISpriteData_BaseImporter");
		}

		// Token: 0x0601F9CF RID: 129487 RVA: 0x002F01CD File Offset: 0x002EE3CD
		protected ULGUISpriteData_BaseImporter(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040110F8 RID: 69880
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/LGUI.LGUISpriteData_BaseImporter";

		// Token: 0x040110F9 RID: 69881
		private static IntPtr _ClassPtr;

		// Token: 0x040110FA RID: 69882
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
