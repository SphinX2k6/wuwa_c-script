using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001E0C RID: 7692
	[UnrealObjectPath("/Script/KuroSimpleCombat.KSC_Move_StageMoveWithScene")]
	[UnrealStructLayout(496, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 496)]
	public class UKSC_Move_StageMoveWithScene : UKSC_Move_Stage, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601D5D6 RID: 120278 RVA: 0x002B594B File Offset: 0x002B3B4B
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKSC_Move_StageMoveWithScene._ClassPtr;
		}

		// Token: 0x0601D5D7 RID: 120279 RVA: 0x002B5958 File Offset: 0x002B3B58
		public UKSC_Move_StageMoveWithScene() : this(BuiltinUtils.AllocNativeUObject(UKSC_Move_StageMoveWithScene.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601D5D8 RID: 120280 RVA: 0x002B5980 File Offset: 0x002B3B80
		[NullableContext(1)]
		public UKSC_Move_StageMoveWithScene(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKSC_Move_StageMoveWithScene.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0601D5D9 RID: 120281 RVA: 0x002B59B3 File Offset: 0x002B3BB3
		static UKSC_Move_StageMoveWithScene()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroSimpleCombat.KSC_Move_StageMoveWithScene");
		}

		// Token: 0x0601D5DA RID: 120282 RVA: 0x002B59C1 File Offset: 0x002B3BC1
		protected UKSC_Move_StageMoveWithScene(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400FED6 RID: 65238
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroSimpleCombat.KSC_Move_StageMoveWithScene";

		// Token: 0x0400FED7 RID: 65239
		private static IntPtr _ClassPtr;

		// Token: 0x0400FED8 RID: 65240
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
