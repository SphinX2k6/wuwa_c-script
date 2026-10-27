using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020018FF RID: 6399
	[UnrealObjectPath("/Script/KuroGameplay.KuroParameterVector")]
	[UnrealStructLayout(24, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 24)]
	public class FKuroParameterVector : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06017BEE RID: 97262 RVA: 0x0022CA17 File Offset: 0x0022AC17
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FKuroParameterVector._ScriptStructPtr != 0) ? FKuroParameterVector._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroGameplay.KuroParameterVector", ref FKuroParameterVector._ScriptStructPtr);
		}

		// Token: 0x17005FA0 RID: 24480
		// (get) Token: 0x06017BEF RID: 97263 RVA: 0x0022CA3B File Offset: 0x0022AC3B
		// (set) Token: 0x06017BF0 RID: 97264 RVA: 0x0022CA4F File Offset: 0x0022AC4F
		public unsafe FName Name
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroParameterVector.__PropertyOffset_Name);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroParameterVector.__PropertyOffset_Name) = value;
			}
		}

		// Token: 0x17005FA1 RID: 24481
		// (get) Token: 0x06017BF1 RID: 97265 RVA: 0x0022CA64 File Offset: 0x0022AC64
		// (set) Token: 0x06017BF2 RID: 97266 RVA: 0x0022CA78 File Offset: 0x0022AC78
		public unsafe FVector Value
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroParameterVector.__PropertyOffset_Value);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroParameterVector.__PropertyOffset_Value) = value;
			}
		}

		// Token: 0x06017BF3 RID: 97267 RVA: 0x0022CA8D File Offset: 0x0022AC8D
		public FKuroParameterVector()
		{
		}

		// Token: 0x06017BF4 RID: 97268 RVA: 0x0022CA95 File Offset: 0x0022AC95
		public FKuroParameterVector(FName Name, FVector Value)
		{
			this.Name = Name;
			this.Value = Value;
		}

		// Token: 0x06017BF5 RID: 97269 RVA: 0x0022CAAB File Offset: 0x0022ACAB
		protected override IntPtr GetUStructPtr()
		{
			return FKuroParameterVector.StaticStruct();
		}

		// Token: 0x06017BF6 RID: 97270 RVA: 0x0022CAB7 File Offset: 0x0022ACB7
		[NullableContext(2)]
		public FKuroParameterVector(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06017BF7 RID: 97271 RVA: 0x0022CAC1 File Offset: 0x0022ACC1
		public FKuroParameterVector(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06017BF8 RID: 97272 RVA: 0x0022CACC File Offset: 0x0022ACCC
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FKuroParameterVector(Pointer, false, true);
		}

		// Token: 0x06017BF9 RID: 97273 RVA: 0x0022CAD6 File Offset: 0x0022ACD6
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FKuroParameterVector(Pointer, MemoryOwner);
		}

		// Token: 0x0400CE29 RID: 52777
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroGameplay.KuroParameterVector";

		// Token: 0x0400CE2A RID: 52778
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400CE2B RID: 52779
		internal static int __PropertyOffset_Name;

		// Token: 0x0400CE2C RID: 52780
		internal static int __PropertyOffset_Value;
	}
}
