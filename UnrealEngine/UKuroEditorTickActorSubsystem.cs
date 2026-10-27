using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001AEA RID: 6890
	[UnrealObjectPath("/Script/KuroRenderingRuntimeBPPlugin.KuroEditorTickActorSubsystem")]
	[UnrealStructLayout(96, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 96)]
	public class UKuroEditorTickActorSubsystem : UWorldSubsystem, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06019B35 RID: 105269 RVA: 0x0025F845 File Offset: 0x0025DA45
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroEditorTickActorSubsystem._ClassPtr;
		}

		// Token: 0x06019B36 RID: 105270 RVA: 0x0025F854 File Offset: 0x0025DA54
		public UKuroEditorTickActorSubsystem() : this(BuiltinUtils.AllocNativeUObject(UKuroEditorTickActorSubsystem.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06019B37 RID: 105271 RVA: 0x0025F87C File Offset: 0x0025DA7C
		[NullableContext(1)]
		public UKuroEditorTickActorSubsystem(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroEditorTickActorSubsystem.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06019B38 RID: 105272 RVA: 0x0025F8AF File Offset: 0x0025DAAF
		static UKuroEditorTickActorSubsystem()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroRenderingRuntimeBPPlugin.KuroEditorTickActorSubsystem");
		}

		// Token: 0x06019B39 RID: 105273 RVA: 0x0025F8BD File Offset: 0x0025DABD
		protected UKuroEditorTickActorSubsystem(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400DFA3 RID: 57251
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroRenderingRuntimeBPPlugin.KuroEditorTickActorSubsystem";

		// Token: 0x0400DFA4 RID: 57252
		private static IntPtr _ClassPtr;

		// Token: 0x0400DFA5 RID: 57253
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
