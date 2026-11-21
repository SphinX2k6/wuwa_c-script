using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020003FB RID: 1019
	[UnrealObjectPath("/Script/KuroGameplay.KuroPerceptionInterface")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public class UKuroPerceptionInterface : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060063FF RID: 25599 RVA: 0x0008EE2B File Offset: 0x0008D02B
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroPerceptionInterface._ClassPtr;
		}

		// Token: 0x06006400 RID: 25600 RVA: 0x0008EE38 File Offset: 0x0008D038
		public UKuroPerceptionInterface() : this(BuiltinUtils.AllocNativeUObject(UKuroPerceptionInterface.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06006401 RID: 25601 RVA: 0x0008EE60 File Offset: 0x0008D060
		[NullableContext(1)]
		public UKuroPerceptionInterface(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroPerceptionInterface.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06006402 RID: 25602
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void UpdatePerceptionRange(uint RangeToken, float Range);

		// Token: 0x06006403 RID: 25603
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void UpdatePerceptionEventDistance(uint Token, float EnterDistance, float LeaveDistance);

		// Token: 0x06006404 RID: 25604
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void UnregisterPlayerPerceptionEvent(uint Token);

		// Token: 0x06006405 RID: 25605
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void RemovePerceptionRange(uint RangeToken);

		// Token: 0x06006406 RID: 25606
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void RefreshDynamicPerceptionRange(uint RangeToken);

		// Token: 0x06006407 RID: 25607
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void MarkElementDisable(uint Token, bool bIsDisable);

		// Token: 0x06006408 RID: 25608 RVA: 0x0008EE93 File Offset: 0x0008D093
		[NullableContext(2)]
		public static void InitializeEnvironment(ushort GridWidth, ushort GridHeight, in TMap<FName, uint> Groups, bool OnlyPlayer, bool OnlyCSharpEnv)
		{
			UKuroPerceptionInterface.__InitializeEnvironment_Internal(GridWidth, GridHeight, (Groups ?? new TMap<FName, uint>()).NativeMapPtr, OnlyPlayer, OnlyCSharpEnv);
		}

		// Token: 0x06006409 RID: 25609 RVA: 0x0008EEAF File Offset: 0x0008D0AF
		[NullableContext(1)]
		public static string GetPlayerPerceptionDebugString(uint Token)
		{
			return FString.ToStringAndDeleteNativePtr(UKuroPerceptionInterface.__GetPlayerPerceptionDebugString_Internal(Token));
		}

		// Token: 0x0600640A RID: 25610
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void DestroyEnvironment();

		// Token: 0x0600640B RID: 25611
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __InitializeEnvironment_Internal(ushort GridWidth, ushort GridHeight, IntPtr Groups, bool OnlyPlayer, bool OnlyCSharpEnv);

		// Token: 0x0600640C RID: 25612
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __GetPlayerPerceptionDebugString_Internal(uint Token);

		// Token: 0x0600640D RID: 25613 RVA: 0x0008EEBC File Offset: 0x0008D0BC
		static UKuroPerceptionInterface()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroGameplay.KuroPerceptionInterface");
		}

		// Token: 0x0600640E RID: 25614 RVA: 0x0008EECA File Offset: 0x0008D0CA
		protected UKuroPerceptionInterface(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04002A3D RID: 10813
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroGameplay.KuroPerceptionInterface";

		// Token: 0x04002A3E RID: 10814
		private static IntPtr _ClassPtr;

		// Token: 0x04002A3F RID: 10815
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
