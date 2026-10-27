using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020019B3 RID: 6579
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroLevelStateMachine.KuroLevelStateLayer")]
	[UnrealStructLayout(136, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 136)]
	public class FKuroLevelStateLayer : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06018799 RID: 100249 RVA: 0x002410A9 File Offset: 0x0023F2A9
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FKuroLevelStateLayer._ScriptStructPtr != 0) ? FKuroLevelStateLayer._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroLevelStateMachine.KuroLevelStateLayer", ref FKuroLevelStateLayer._ScriptStructPtr);
		}

		// Token: 0x170061BC RID: 25020
		// (get) Token: 0x0601879A RID: 100250 RVA: 0x002410CD File Offset: 0x0023F2CD
		// (set) Token: 0x0601879B RID: 100251 RVA: 0x002410E1 File Offset: 0x0023F2E1
		public unsafe FName InitialStateName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroLevelStateLayer.__PropertyOffset_InitialStateName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroLevelStateLayer.__PropertyOffset_InitialStateName) = value;
			}
		}

		// Token: 0x170061BD RID: 25021
		// (get) Token: 0x0601879C RID: 100252 RVA: 0x002410F8 File Offset: 0x0023F2F8
		// (set) Token: 0x0601879D RID: 100253 RVA: 0x0024113B File Offset: 0x0023F33B
		public TArray<FKuroLevelState> States
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FKuroLevelState> result;
				if ((result = this._States) == null)
				{
					result = (this._States = new TArray<FKuroLevelState>(base.NativePtr + (IntPtr)FKuroLevelStateLayer.__PropertyOffset_States, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.States.CopyAssign(value);
			}
		}

		// Token: 0x0601879E RID: 100254 RVA: 0x00241149 File Offset: 0x0023F349
		public FKuroLevelStateLayer()
		{
		}

		// Token: 0x0601879F RID: 100255 RVA: 0x00241151 File Offset: 0x0023F351
		public FKuroLevelStateLayer(FName InitialStateName, TArray<FKuroLevelState> States)
		{
			this.InitialStateName = InitialStateName;
			this.States = States;
		}

		// Token: 0x060187A0 RID: 100256 RVA: 0x00241167 File Offset: 0x0023F367
		protected override IntPtr GetUStructPtr()
		{
			return FKuroLevelStateLayer.StaticStruct();
		}

		// Token: 0x060187A1 RID: 100257 RVA: 0x00241173 File Offset: 0x0023F373
		[NullableContext(2)]
		public FKuroLevelStateLayer(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060187A2 RID: 100258 RVA: 0x0024117D File Offset: 0x0023F37D
		public FKuroLevelStateLayer(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060187A3 RID: 100259 RVA: 0x00241188 File Offset: 0x0023F388
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FKuroLevelStateLayer(Pointer, false, true);
		}

		// Token: 0x060187A4 RID: 100260 RVA: 0x00241192 File Offset: 0x0023F392
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FKuroLevelStateLayer(Pointer, MemoryOwner);
		}

		// Token: 0x0400D38C RID: 54156
		public const string __ObjectPath = "/Script/KuroLevelStateMachine.KuroLevelStateLayer";

		// Token: 0x0400D38D RID: 54157
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400D38E RID: 54158
		internal static int __PropertyOffset_InitialStateName;

		// Token: 0x0400D38F RID: 54159
		internal static int __PropertyOffset_States;

		// Token: 0x0400D390 RID: 54160
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FKuroLevelState> _States;
	}
}
