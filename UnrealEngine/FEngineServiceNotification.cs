using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000790 RID: 1936
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/EngineMessages.EngineServiceNotification")]
	[UnrealStructLayout(24, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 24)]
	public class FEngineServiceNotification : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060064D9 RID: 25817 RVA: 0x00090A85 File Offset: 0x0008EC85
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FEngineServiceNotification._ScriptStructPtr != 0) ? FEngineServiceNotification._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/EngineMessages.EngineServiceNotification", ref FEngineServiceNotification._ScriptStructPtr);
		}

		// Token: 0x170017F0 RID: 6128
		// (get) Token: 0x060064DA RID: 25818 RVA: 0x00090AA9 File Offset: 0x0008ECA9
		// (set) Token: 0x060064DB RID: 25819 RVA: 0x00090ABD File Offset: 0x0008ECBD
		public unsafe string Text
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FEngineServiceNotification.__PropertyOffset_Text)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FEngineServiceNotification.__PropertyOffset_Text)), value);
			}
		}

		// Token: 0x170017F1 RID: 6129
		// (get) Token: 0x060064DC RID: 25820 RVA: 0x00090AD2 File Offset: 0x0008ECD2
		// (set) Token: 0x060064DD RID: 25821 RVA: 0x00090AE2 File Offset: 0x0008ECE2
		public unsafe double TimeSeconds
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FEngineServiceNotification.__PropertyOffset_TimeSeconds);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FEngineServiceNotification.__PropertyOffset_TimeSeconds) = value;
			}
		}

		// Token: 0x060064DE RID: 25822 RVA: 0x00090AF3 File Offset: 0x0008ECF3
		public FEngineServiceNotification()
		{
		}

		// Token: 0x060064DF RID: 25823 RVA: 0x00090AFB File Offset: 0x0008ECFB
		public FEngineServiceNotification(string Text, double TimeSeconds)
		{
			this.Text = Text;
			this.TimeSeconds = TimeSeconds;
		}

		// Token: 0x060064E0 RID: 25824 RVA: 0x00090B11 File Offset: 0x0008ED11
		protected override IntPtr GetUStructPtr()
		{
			return FEngineServiceNotification.StaticStruct();
		}

		// Token: 0x060064E1 RID: 25825 RVA: 0x00090B1D File Offset: 0x0008ED1D
		[NullableContext(2)]
		public FEngineServiceNotification(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060064E2 RID: 25826 RVA: 0x00090B27 File Offset: 0x0008ED27
		public FEngineServiceNotification(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060064E3 RID: 25827 RVA: 0x00090B32 File Offset: 0x0008ED32
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FEngineServiceNotification(Pointer, false, true);
		}

		// Token: 0x060064E4 RID: 25828 RVA: 0x00090B3C File Offset: 0x0008ED3C
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FEngineServiceNotification(Pointer, MemoryOwner);
		}

		// Token: 0x040030DF RID: 12511
		public const string __ObjectPath = "/Script/EngineMessages.EngineServiceNotification";

		// Token: 0x040030E0 RID: 12512
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040030E1 RID: 12513
		internal static int __PropertyOffset_Text;

		// Token: 0x040030E2 RID: 12514
		internal static int __PropertyOffset_TimeSeconds;
	}
}
