using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200078E RID: 1934
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/EngineMessages.EngineServiceAuthGrant")]
	[UnrealStructLayout(32, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 32)]
	public class FEngineServiceAuthGrant : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060064C1 RID: 25793 RVA: 0x000908F5 File Offset: 0x0008EAF5
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FEngineServiceAuthGrant._ScriptStructPtr != 0) ? FEngineServiceAuthGrant._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/EngineMessages.EngineServiceAuthGrant", ref FEngineServiceAuthGrant._ScriptStructPtr);
		}

		// Token: 0x170017EC RID: 6124
		// (get) Token: 0x060064C2 RID: 25794 RVA: 0x00090919 File Offset: 0x0008EB19
		// (set) Token: 0x060064C3 RID: 25795 RVA: 0x0009092D File Offset: 0x0008EB2D
		public unsafe string UserName
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FEngineServiceAuthGrant.__PropertyOffset_UserName)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FEngineServiceAuthGrant.__PropertyOffset_UserName)), value);
			}
		}

		// Token: 0x170017ED RID: 6125
		// (get) Token: 0x060064C4 RID: 25796 RVA: 0x00090942 File Offset: 0x0008EB42
		// (set) Token: 0x060064C5 RID: 25797 RVA: 0x00090956 File Offset: 0x0008EB56
		public unsafe string UserToGrant
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FEngineServiceAuthGrant.__PropertyOffset_UserToGrant)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FEngineServiceAuthGrant.__PropertyOffset_UserToGrant)), value);
			}
		}

		// Token: 0x060064C6 RID: 25798 RVA: 0x0009096B File Offset: 0x0008EB6B
		public FEngineServiceAuthGrant()
		{
		}

		// Token: 0x060064C7 RID: 25799 RVA: 0x00090973 File Offset: 0x0008EB73
		public FEngineServiceAuthGrant(string UserName, string UserToGrant)
		{
			this.UserName = UserName;
			this.UserToGrant = UserToGrant;
		}

		// Token: 0x060064C8 RID: 25800 RVA: 0x00090989 File Offset: 0x0008EB89
		protected override IntPtr GetUStructPtr()
		{
			return FEngineServiceAuthGrant.StaticStruct();
		}

		// Token: 0x060064C9 RID: 25801 RVA: 0x00090995 File Offset: 0x0008EB95
		[NullableContext(2)]
		public FEngineServiceAuthGrant(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060064CA RID: 25802 RVA: 0x0009099F File Offset: 0x0008EB9F
		public FEngineServiceAuthGrant(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060064CB RID: 25803 RVA: 0x000909AA File Offset: 0x0008EBAA
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FEngineServiceAuthGrant(Pointer, false, true);
		}

		// Token: 0x060064CC RID: 25804 RVA: 0x000909B4 File Offset: 0x0008EBB4
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FEngineServiceAuthGrant(Pointer, MemoryOwner);
		}

		// Token: 0x040030D7 RID: 12503
		public const string __ObjectPath = "/Script/EngineMessages.EngineServiceAuthGrant";

		// Token: 0x040030D8 RID: 12504
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040030D9 RID: 12505
		internal static int __PropertyOffset_UserName;

		// Token: 0x040030DA RID: 12506
		internal static int __PropertyOffset_UserToGrant;
	}
}
