using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000793 RID: 1939
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/EngineMessages.EngineServiceTerminate")]
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 16)]
	public class FEngineServiceTerminate : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06006500 RID: 25856 RVA: 0x00090D7D File Offset: 0x0008EF7D
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FEngineServiceTerminate._ScriptStructPtr != 0) ? FEngineServiceTerminate._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/EngineMessages.EngineServiceTerminate", ref FEngineServiceTerminate._ScriptStructPtr);
		}

		// Token: 0x170017F9 RID: 6137
		// (get) Token: 0x06006501 RID: 25857 RVA: 0x00090DA1 File Offset: 0x0008EFA1
		// (set) Token: 0x06006502 RID: 25858 RVA: 0x00090DB5 File Offset: 0x0008EFB5
		public unsafe string UserName
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FEngineServiceTerminate.__PropertyOffset_UserName)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FEngineServiceTerminate.__PropertyOffset_UserName)), value);
			}
		}

		// Token: 0x06006503 RID: 25859 RVA: 0x00090DCA File Offset: 0x0008EFCA
		public FEngineServiceTerminate()
		{
		}

		// Token: 0x06006504 RID: 25860 RVA: 0x00090DD2 File Offset: 0x0008EFD2
		public FEngineServiceTerminate(string UserName)
		{
			this.UserName = UserName;
		}

		// Token: 0x06006505 RID: 25861 RVA: 0x00090DE1 File Offset: 0x0008EFE1
		protected override IntPtr GetUStructPtr()
		{
			return FEngineServiceTerminate.StaticStruct();
		}

		// Token: 0x06006506 RID: 25862 RVA: 0x00090DED File Offset: 0x0008EFED
		[NullableContext(2)]
		public FEngineServiceTerminate(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06006507 RID: 25863 RVA: 0x00090DF7 File Offset: 0x0008EFF7
		public FEngineServiceTerminate(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06006508 RID: 25864 RVA: 0x00090E02 File Offset: 0x0008F002
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FEngineServiceTerminate(Pointer, false, true);
		}

		// Token: 0x06006509 RID: 25865 RVA: 0x00090E0C File Offset: 0x0008F00C
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FEngineServiceTerminate(Pointer, MemoryOwner);
		}

		// Token: 0x040030EE RID: 12526
		public const string __ObjectPath = "/Script/EngineMessages.EngineServiceTerminate";

		// Token: 0x040030EF RID: 12527
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040030F0 RID: 12528
		internal static int __PropertyOffset_UserName;
	}
}
