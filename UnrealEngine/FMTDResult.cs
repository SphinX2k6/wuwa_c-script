using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000EC1 RID: 3777
	[UnrealObjectPath("/Script/Engine.MTDResult")]
	[UnrealStructLayout(16, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 16)]
	public class FMTDResult : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600CC85 RID: 52357 RVA: 0x0012A093 File Offset: 0x00128293
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FMTDResult._ScriptStructPtr != 0) ? FMTDResult._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.MTDResult", ref FMTDResult._ScriptStructPtr);
		}

		// Token: 0x17003018 RID: 12312
		// (get) Token: 0x0600CC86 RID: 52358 RVA: 0x0012A0B7 File Offset: 0x001282B7
		// (set) Token: 0x0600CC87 RID: 52359 RVA: 0x0012A0CB File Offset: 0x001282CB
		public unsafe FVector Direction
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMTDResult.__PropertyOffset_Direction);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMTDResult.__PropertyOffset_Direction) = value;
			}
		}

		// Token: 0x17003019 RID: 12313
		// (get) Token: 0x0600CC88 RID: 52360 RVA: 0x0012A0E0 File Offset: 0x001282E0
		// (set) Token: 0x0600CC89 RID: 52361 RVA: 0x0012A0F0 File Offset: 0x001282F0
		public unsafe float Distance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMTDResult.__PropertyOffset_Distance);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMTDResult.__PropertyOffset_Distance) = value;
			}
		}

		// Token: 0x0600CC8A RID: 52362 RVA: 0x0012A101 File Offset: 0x00128301
		public FMTDResult()
		{
		}

		// Token: 0x0600CC8B RID: 52363 RVA: 0x0012A109 File Offset: 0x00128309
		public FMTDResult(FVector Direction, float Distance)
		{
			this.Direction = Direction;
			this.Distance = Distance;
		}

		// Token: 0x0600CC8C RID: 52364 RVA: 0x0012A11F File Offset: 0x0012831F
		protected override IntPtr GetUStructPtr()
		{
			return FMTDResult.StaticStruct();
		}

		// Token: 0x0600CC8D RID: 52365 RVA: 0x0012A12B File Offset: 0x0012832B
		[NullableContext(2)]
		public FMTDResult(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600CC8E RID: 52366 RVA: 0x0012A135 File Offset: 0x00128335
		public FMTDResult(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600CC8F RID: 52367 RVA: 0x0012A140 File Offset: 0x00128340
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FMTDResult(Pointer, false, true);
		}

		// Token: 0x0600CC90 RID: 52368 RVA: 0x0012A14A File Offset: 0x0012834A
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FMTDResult(Pointer, MemoryOwner);
		}

		// Token: 0x04006E25 RID: 28197
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.MTDResult";

		// Token: 0x04006E26 RID: 28198
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04006E27 RID: 28199
		internal static int __PropertyOffset_Direction;

		// Token: 0x04006E28 RID: 28200
		internal static int __PropertyOffset_Distance;
	}
}
