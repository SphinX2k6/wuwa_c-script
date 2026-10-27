using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02002760 RID: 10080
	[UnrealObjectPath("/Script/Sharphereal.KooSharpMonoTraceLevelRuntimeSettings")]
	[UnrealStructLayout(8, 1, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 8)]
	public class FKooSharpMonoTraceLevelRuntimeSettings : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06025AE9 RID: 154345 RVA: 0x00391AFE File Offset: 0x0038FCFE
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FKooSharpMonoTraceLevelRuntimeSettings._ScriptStructPtr != 0) ? FKooSharpMonoTraceLevelRuntimeSettings._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Sharphereal.KooSharpMonoTraceLevelRuntimeSettings", ref FKooSharpMonoTraceLevelRuntimeSettings._ScriptStructPtr);
		}

		// Token: 0x1700910C RID: 37132
		// (get) Token: 0x06025AEA RID: 154346 RVA: 0x00391B22 File Offset: 0x0038FD22
		// (set) Token: 0x06025AEB RID: 154347 RVA: 0x00391B32 File Offset: 0x0038FD32
		public unsafe EKooSharpMonoTraceLevel Debug
		{
			get
			{
				return (EKooSharpMonoTraceLevel)(*(base.NativePtr + (IntPtr)FKooSharpMonoTraceLevelRuntimeSettings.__PropertyOffset_Debug));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKooSharpMonoTraceLevelRuntimeSettings.__PropertyOffset_Debug) = (byte)value;
			}
		}

		// Token: 0x1700910D RID: 37133
		// (get) Token: 0x06025AEC RID: 154348 RVA: 0x00391B43 File Offset: 0x0038FD43
		// (set) Token: 0x06025AED RID: 154349 RVA: 0x00391B53 File Offset: 0x0038FD53
		public unsafe EKooSharpMonoTraceLevel DebugGame
		{
			get
			{
				return (EKooSharpMonoTraceLevel)(*(base.NativePtr + (IntPtr)FKooSharpMonoTraceLevelRuntimeSettings.__PropertyOffset_DebugGame));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKooSharpMonoTraceLevelRuntimeSettings.__PropertyOffset_DebugGame) = (byte)value;
			}
		}

		// Token: 0x1700910E RID: 37134
		// (get) Token: 0x06025AEE RID: 154350 RVA: 0x00391B64 File Offset: 0x0038FD64
		// (set) Token: 0x06025AEF RID: 154351 RVA: 0x00391B74 File Offset: 0x0038FD74
		public unsafe EKooSharpMonoTraceLevel Development
		{
			get
			{
				return (EKooSharpMonoTraceLevel)(*(base.NativePtr + (IntPtr)FKooSharpMonoTraceLevelRuntimeSettings.__PropertyOffset_Development));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKooSharpMonoTraceLevelRuntimeSettings.__PropertyOffset_Development) = (byte)value;
			}
		}

		// Token: 0x1700910F RID: 37135
		// (get) Token: 0x06025AF0 RID: 154352 RVA: 0x00391B85 File Offset: 0x0038FD85
		// (set) Token: 0x06025AF1 RID: 154353 RVA: 0x00391B95 File Offset: 0x0038FD95
		public unsafe EKooSharpMonoTraceLevel Test
		{
			get
			{
				return (EKooSharpMonoTraceLevel)(*(base.NativePtr + (IntPtr)FKooSharpMonoTraceLevelRuntimeSettings.__PropertyOffset_Test));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKooSharpMonoTraceLevelRuntimeSettings.__PropertyOffset_Test) = (byte)value;
			}
		}

		// Token: 0x17009110 RID: 37136
		// (get) Token: 0x06025AF2 RID: 154354 RVA: 0x00391BA6 File Offset: 0x0038FDA6
		// (set) Token: 0x06025AF3 RID: 154355 RVA: 0x00391BB6 File Offset: 0x0038FDB6
		public unsafe EKooSharpMonoTraceLevel Shipping
		{
			get
			{
				return (EKooSharpMonoTraceLevel)(*(base.NativePtr + (IntPtr)FKooSharpMonoTraceLevelRuntimeSettings.__PropertyOffset_Shipping));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKooSharpMonoTraceLevelRuntimeSettings.__PropertyOffset_Shipping) = (byte)value;
			}
		}

		// Token: 0x06025AF4 RID: 154356 RVA: 0x00391BC7 File Offset: 0x0038FDC7
		public FKooSharpMonoTraceLevelRuntimeSettings()
		{
		}

		// Token: 0x06025AF5 RID: 154357 RVA: 0x00391BCF File Offset: 0x0038FDCF
		public FKooSharpMonoTraceLevelRuntimeSettings(EKooSharpMonoTraceLevel Debug, EKooSharpMonoTraceLevel DebugEditor, EKooSharpMonoTraceLevel DebugGame, EKooSharpMonoTraceLevel DebugGameEditor, EKooSharpMonoTraceLevel Development, EKooSharpMonoTraceLevel DevelopmentEditor, EKooSharpMonoTraceLevel Test, EKooSharpMonoTraceLevel Shipping)
		{
			this.Debug = Debug;
			this.DebugGame = DebugGame;
			this.Development = Development;
			this.Test = Test;
			this.Shipping = Shipping;
		}

		// Token: 0x06025AF6 RID: 154358 RVA: 0x00391BFD File Offset: 0x0038FDFD
		protected override IntPtr GetUStructPtr()
		{
			return FKooSharpMonoTraceLevelRuntimeSettings.StaticStruct();
		}

		// Token: 0x06025AF7 RID: 154359 RVA: 0x00391C09 File Offset: 0x0038FE09
		[NullableContext(2)]
		public FKooSharpMonoTraceLevelRuntimeSettings(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06025AF8 RID: 154360 RVA: 0x00391C13 File Offset: 0x0038FE13
		public FKooSharpMonoTraceLevelRuntimeSettings(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06025AF9 RID: 154361 RVA: 0x00391C1E File Offset: 0x0038FE1E
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FKooSharpMonoTraceLevelRuntimeSettings(Pointer, false, true);
		}

		// Token: 0x06025AFA RID: 154362 RVA: 0x00391C28 File Offset: 0x0038FE28
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FKooSharpMonoTraceLevelRuntimeSettings(Pointer, MemoryOwner);
		}

		// Token: 0x0401482E RID: 84014
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Sharphereal.KooSharpMonoTraceLevelRuntimeSettings";

		// Token: 0x0401482F RID: 84015
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04014830 RID: 84016
		internal static int __PropertyOffset_Debug;

		// Token: 0x04014831 RID: 84017
		internal static int __PropertyOffset_DebugGame;

		// Token: 0x04014832 RID: 84018
		internal static int __PropertyOffset_Development;

		// Token: 0x04014833 RID: 84019
		internal static int __PropertyOffset_Test;

		// Token: 0x04014834 RID: 84020
		internal static int __PropertyOffset_Shipping;
	}
}
