using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020005EA RID: 1514
	[UnrealObjectPath("/Script/KuroUtility.KuroSubLevelVisibleSubsystem")]
	[UnrealStructLayout(192, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 192)]
	public class UKuroSubLevelVisibleSubsystem : UGameInstanceSubsystem, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060086D2 RID: 34514 RVA: 0x000CA14A File Offset: 0x000C834A
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroSubLevelVisibleSubsystem._ClassPtr;
		}

		// Token: 0x060086D3 RID: 34515 RVA: 0x000CA158 File Offset: 0x000C8358
		public UKuroSubLevelVisibleSubsystem() : this(BuiltinUtils.AllocNativeUObject(UKuroSubLevelVisibleSubsystem.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060086D4 RID: 34516 RVA: 0x000CA180 File Offset: 0x000C8380
		[NullableContext(1)]
		public UKuroSubLevelVisibleSubsystem(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroSubLevelVisibleSubsystem.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x060086D5 RID: 34517 RVA: 0x000CA1B3 File Offset: 0x000C83B3
		public void SetOneFrameExecuteCount(int Count)
		{
			UKuroSubLevelVisibleSubsystem.__SetOneFrameExecuteCount_Internal(base.NativePtr, Count);
		}

		// Token: 0x060086D6 RID: 34518 RVA: 0x000CA1C1 File Offset: 0x000C83C1
		[NullableContext(2)]
		public bool SetLevelActorsVisible(int LinkId, bool Visible, FSetVisibleFinishDelegate FinishCallback)
		{
			return UKuroSubLevelVisibleSubsystem.__SetLevelActorsVisible_Internal(base.NativePtr, LinkId, Visible, (FinishCallback != null) ? FinishCallback.NativePtr : ((IntPtr)0));
		}

		// Token: 0x060086D7 RID: 34519 RVA: 0x000CA1DD File Offset: 0x000C83DD
		public void RemoveLevel(int LinkId)
		{
			UKuroSubLevelVisibleSubsystem.__RemoveLevel_Internal(base.NativePtr, LinkId);
		}

		// Token: 0x060086D8 RID: 34520 RVA: 0x000CA1EB File Offset: 0x000C83EB
		[NullableContext(2)]
		public static UKuroSubLevelVisibleSubsystem GetSubSystem(UGameInstance GameInstance)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UKuroSubLevelVisibleSubsystem>(UKuroSubLevelVisibleSubsystem.__GetSubSystem_Internal((GameInstance != null) ? GameInstance.NativePtr : IntPtr.Zero));
		}

		// Token: 0x060086D9 RID: 34521 RVA: 0x000CA207 File Offset: 0x000C8407
		[NullableContext(2)]
		public void AddLevel(int LinkId, ULevel Level)
		{
			UKuroSubLevelVisibleSubsystem.__AddLevel_Internal(base.NativePtr, LinkId, (Level != null) ? Level.NativePtr : IntPtr.Zero);
		}

		// Token: 0x060086DA RID: 34522
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetOneFrameExecuteCount_Internal(IntPtr @this, int Count);

		// Token: 0x060086DB RID: 34523
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __SetLevelActorsVisible_Internal(IntPtr @this, int LinkId, bool Visible, IntPtr FinishCallback);

		// Token: 0x060086DC RID: 34524
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __RemoveLevel_Internal(IntPtr @this, int LinkId);

		// Token: 0x060086DD RID: 34525
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetSubSystem_Internal(IntPtr GameInstance);

		// Token: 0x060086DE RID: 34526
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __AddLevel_Internal(IntPtr @this, int LinkId, IntPtr Level);

		// Token: 0x060086DF RID: 34527 RVA: 0x000CA225 File Offset: 0x000C8425
		static UKuroSubLevelVisibleSubsystem()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroUtility.KuroSubLevelVisibleSubsystem");
		}

		// Token: 0x060086E0 RID: 34528 RVA: 0x000CA233 File Offset: 0x000C8433
		protected UKuroSubLevelVisibleSubsystem(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04003AB2 RID: 15026
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroUtility.KuroSubLevelVisibleSubsystem";

		// Token: 0x04003AB3 RID: 15027
		private static IntPtr _ClassPtr;

		// Token: 0x04003AB4 RID: 15028
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
