using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200044B RID: 1099
	[UnrealObjectPath("/Script/ChaosSolverEngine.ChaosDebugSubstepControl")]
	[UnrealStructLayout(24, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 24)]
	public class FChaosDebugSubstepControl : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06003B53 RID: 15187 RVA: 0x0005975E File Offset: 0x0005795E
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FChaosDebugSubstepControl._ScriptStructPtr != 0) ? FChaosDebugSubstepControl._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ChaosSolverEngine.ChaosDebugSubstepControl", ref FChaosDebugSubstepControl._ScriptStructPtr);
		}

		// Token: 0x17000E4F RID: 3663
		// (get) Token: 0x06003B54 RID: 15188 RVA: 0x00059782 File Offset: 0x00057982
		// (set) Token: 0x06003B55 RID: 15189 RVA: 0x00059792 File Offset: 0x00057992
		public unsafe bool bPause
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FChaosDebugSubstepControl.__PropertyOffset_bPause) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FChaosDebugSubstepControl.__PropertyOffset_bPause) = (value ? 1 : 0);
			}
		}

		// Token: 0x17000E50 RID: 3664
		// (get) Token: 0x06003B56 RID: 15190 RVA: 0x000597A3 File Offset: 0x000579A3
		// (set) Token: 0x06003B57 RID: 15191 RVA: 0x000597B3 File Offset: 0x000579B3
		public unsafe bool bSubstep
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FChaosDebugSubstepControl.__PropertyOffset_bSubstep) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FChaosDebugSubstepControl.__PropertyOffset_bSubstep) = (value ? 1 : 0);
			}
		}

		// Token: 0x17000E51 RID: 3665
		// (get) Token: 0x06003B58 RID: 15192 RVA: 0x000597C4 File Offset: 0x000579C4
		// (set) Token: 0x06003B59 RID: 15193 RVA: 0x000597D4 File Offset: 0x000579D4
		public unsafe bool bStep
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FChaosDebugSubstepControl.__PropertyOffset_bStep) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FChaosDebugSubstepControl.__PropertyOffset_bStep) = (value ? 1 : 0);
			}
		}

		// Token: 0x06003B5A RID: 15194 RVA: 0x000597E5 File Offset: 0x000579E5
		public FChaosDebugSubstepControl()
		{
		}

		// Token: 0x06003B5B RID: 15195 RVA: 0x000597ED File Offset: 0x000579ED
		public FChaosDebugSubstepControl(bool bPause, bool bSubstep, bool bStep)
		{
			this.bPause = bPause;
			this.bSubstep = bSubstep;
			this.bStep = bStep;
		}

		// Token: 0x06003B5C RID: 15196 RVA: 0x0005980A File Offset: 0x00057A0A
		protected override IntPtr GetUStructPtr()
		{
			return FChaosDebugSubstepControl.StaticStruct();
		}

		// Token: 0x06003B5D RID: 15197 RVA: 0x00059816 File Offset: 0x00057A16
		[NullableContext(2)]
		public FChaosDebugSubstepControl(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06003B5E RID: 15198 RVA: 0x00059820 File Offset: 0x00057A20
		public FChaosDebugSubstepControl(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06003B5F RID: 15199 RVA: 0x0005982B File Offset: 0x00057A2B
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FChaosDebugSubstepControl(Pointer, false, true);
		}

		// Token: 0x06003B60 RID: 15200 RVA: 0x00059835 File Offset: 0x00057A35
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FChaosDebugSubstepControl(Pointer, MemoryOwner);
		}

		// Token: 0x04001B4D RID: 6989
		[Nullable(1)]
		public const string __ObjectPath = "/Script/ChaosSolverEngine.ChaosDebugSubstepControl";

		// Token: 0x04001B4E RID: 6990
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04001B4F RID: 6991
		internal static int __PropertyOffset_bPause;

		// Token: 0x04001B50 RID: 6992
		internal static int __PropertyOffset_bSubstep;

		// Token: 0x04001B51 RID: 6993
		internal static int __PropertyOffset_bStep;
	}
}
