using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000D28 RID: 3368
	[UnrealObjectPath("/Script/Engine.LevelInstanceComponent")]
	[UnrealStructLayout(576, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 576)]
	public class ULevelInstanceComponent : USceneComponent, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600B4B0 RID: 46256 RVA: 0x00101B2D File Offset: 0x000FFD2D
		public new static UClassStackOnlyPtr StaticClass()
		{
			return ULevelInstanceComponent._ClassPtr;
		}

		// Token: 0x0600B4B1 RID: 46257 RVA: 0x00101B3C File Offset: 0x000FFD3C
		public ULevelInstanceComponent() : this(BuiltinUtils.AllocNativeUObject(ULevelInstanceComponent.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600B4B2 RID: 46258 RVA: 0x00101B64 File Offset: 0x000FFD64
		[NullableContext(1)]
		public ULevelInstanceComponent(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(ULevelInstanceComponent.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0600B4B3 RID: 46259 RVA: 0x00101B97 File Offset: 0x000FFD97
		static ULevelInstanceComponent()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.LevelInstanceComponent");
		}

		// Token: 0x0600B4B4 RID: 46260 RVA: 0x00101BA5 File Offset: 0x000FFDA5
		protected ULevelInstanceComponent(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04005EFD RID: 24317
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.LevelInstanceComponent";

		// Token: 0x04005EFE RID: 24318
		private static IntPtr _ClassPtr;

		// Token: 0x04005EFF RID: 24319
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
