using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000D32 RID: 3378
	[UnrealObjectPath("/Script/Engine.LevelInstanceSubsystem")]
	[UnrealStructLayout(704, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 704)]
	public class ULevelInstanceSubsystem : UWorldSubsystem, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600B4E6 RID: 46310 RVA: 0x00102112 File Offset: 0x00100312
		public new static UClassStackOnlyPtr StaticClass()
		{
			return ULevelInstanceSubsystem._ClassPtr;
		}

		// Token: 0x0600B4E7 RID: 46311 RVA: 0x00102120 File Offset: 0x00100320
		public ULevelInstanceSubsystem() : this(BuiltinUtils.AllocNativeUObject(ULevelInstanceSubsystem.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600B4E8 RID: 46312 RVA: 0x00102148 File Offset: 0x00100348
		[NullableContext(1)]
		public ULevelInstanceSubsystem(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(ULevelInstanceSubsystem.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0600B4E9 RID: 46313 RVA: 0x0010217B File Offset: 0x0010037B
		[NullableContext(2)]
		public ILevelInstanceInterface K2_GetOwningLevelInstance(ULevel Level)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer(ULevelInstanceSubsystem.__K2_GetOwningLevelInstance_Internal(base.NativePtr, (Level != null) ? Level.NativePtr : IntPtr.Zero).ObjectPointer) as ILevelInstanceInterface;
		}

		// Token: 0x0600B4EA RID: 46314
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FScriptInterface __K2_GetOwningLevelInstance_Internal(IntPtr @this, IntPtr Level);

		// Token: 0x0600B4EB RID: 46315 RVA: 0x001021A7 File Offset: 0x001003A7
		static ULevelInstanceSubsystem()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.LevelInstanceSubsystem");
		}

		// Token: 0x0600B4EC RID: 46316 RVA: 0x001021B5 File Offset: 0x001003B5
		protected ULevelInstanceSubsystem(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04005F1A RID: 24346
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.LevelInstanceSubsystem";

		// Token: 0x04005F1B RID: 24347
		private static IntPtr _ClassPtr;

		// Token: 0x04005F1C RID: 24348
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
