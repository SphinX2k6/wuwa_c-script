using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001ED6 RID: 7894
	[UnrealObjectPath("/Script/KuroUtility.KuroSubLevelVisibleSubsystem")]
	[UnrealStructLayout(192, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 192)]
	public class UKuroSubLevelVisibleSubsystem : UGameInstanceSubsystem, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601E04F RID: 122959 RVA: 0x002C89D7 File Offset: 0x002C6BD7
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroSubLevelVisibleSubsystem._ClassPtr;
		}

		// Token: 0x0601E050 RID: 122960 RVA: 0x002C89E4 File Offset: 0x002C6BE4
		public UKuroSubLevelVisibleSubsystem() : this(BuiltinUtils.AllocNativeUObject(UKuroSubLevelVisibleSubsystem.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601E051 RID: 122961 RVA: 0x002C8A0C File Offset: 0x002C6C0C
		[NullableContext(1)]
		public UKuroSubLevelVisibleSubsystem(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroSubLevelVisibleSubsystem.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0601E052 RID: 122962 RVA: 0x002C8A3F File Offset: 0x002C6C3F
		public void SetOneFrameExecuteCount(int Count)
		{
			UKuroSubLevelVisibleSubsystem.__SetOneFrameExecuteCount_Internal(base.NativePtr, Count);
		}

		// Token: 0x0601E053 RID: 122963 RVA: 0x002C8A4D File Offset: 0x002C6C4D
		[NullableContext(2)]
		public bool SetLevelActorsVisible(int LinkId, bool Visible, FSetVisibleFinishDelegate FinishCallback)
		{
			return UKuroSubLevelVisibleSubsystem.__SetLevelActorsVisible_Internal(base.NativePtr, LinkId, Visible, (FinishCallback != null) ? FinishCallback.NativePtr : ((IntPtr)0));
		}

		// Token: 0x0601E054 RID: 122964 RVA: 0x002C8A69 File Offset: 0x002C6C69
		public void RemoveLevel(int LinkId)
		{
			UKuroSubLevelVisibleSubsystem.__RemoveLevel_Internal(base.NativePtr, LinkId);
		}

		// Token: 0x0601E055 RID: 122965 RVA: 0x002C8A77 File Offset: 0x002C6C77
		[NullableContext(2)]
		public static UKuroSubLevelVisibleSubsystem GetSubSystem(UGameInstance GameInstance)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UKuroSubLevelVisibleSubsystem>(UKuroSubLevelVisibleSubsystem.__GetSubSystem_Internal((GameInstance != null) ? GameInstance.NativePtr : IntPtr.Zero));
		}

		// Token: 0x0601E056 RID: 122966 RVA: 0x002C8A93 File Offset: 0x002C6C93
		[NullableContext(2)]
		public void AddLevel(int LinkId, ULevel Level)
		{
			UKuroSubLevelVisibleSubsystem.__AddLevel_Internal(base.NativePtr, LinkId, (Level != null) ? Level.NativePtr : IntPtr.Zero);
		}

		// Token: 0x0601E057 RID: 122967
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetOneFrameExecuteCount_Internal(IntPtr @this, int Count);

		// Token: 0x0601E058 RID: 122968
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __SetLevelActorsVisible_Internal(IntPtr @this, int LinkId, bool Visible, IntPtr FinishCallback);

		// Token: 0x0601E059 RID: 122969
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __RemoveLevel_Internal(IntPtr @this, int LinkId);

		// Token: 0x0601E05A RID: 122970
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetSubSystem_Internal(IntPtr GameInstance);

		// Token: 0x0601E05B RID: 122971
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __AddLevel_Internal(IntPtr @this, int LinkId, IntPtr Level);

		// Token: 0x0601E05C RID: 122972 RVA: 0x002C8AB1 File Offset: 0x002C6CB1
		static UKuroSubLevelVisibleSubsystem()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroUtility.KuroSubLevelVisibleSubsystem");
		}

		// Token: 0x0601E05D RID: 122973 RVA: 0x002C8ABF File Offset: 0x002C6CBF
		protected UKuroSubLevelVisibleSubsystem(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040103C4 RID: 66500
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroUtility.KuroSubLevelVisibleSubsystem";

		// Token: 0x040103C5 RID: 66501
		private static IntPtr _ClassPtr;

		// Token: 0x040103C6 RID: 66502
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
