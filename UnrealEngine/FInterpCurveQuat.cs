using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000123 RID: 291
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/CoreUObject.InterpCurveQuat")]
	[UnrealStructLayout(24, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 24)]
	public class FInterpCurveQuat : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060011E2 RID: 4578 RVA: 0x0001C5B6 File Offset: 0x0001A7B6
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FInterpCurveQuat._ScriptStructPtr != 0) ? FInterpCurveQuat._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/CoreUObject.InterpCurveQuat", ref FInterpCurveQuat._ScriptStructPtr);
		}

		// Token: 0x170001C1 RID: 449
		// (get) Token: 0x060011E3 RID: 4579 RVA: 0x0001C5DC File Offset: 0x0001A7DC
		// (set) Token: 0x060011E4 RID: 4580 RVA: 0x0001C61F File Offset: 0x0001A81F
		public TArray<FInterpCurvePointQuat> Points
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FInterpCurvePointQuat> result;
				if ((result = this._Points) == null)
				{
					result = (this._Points = new TArray<FInterpCurvePointQuat>(base.NativePtr + (IntPtr)FInterpCurveQuat.__PropertyOffset_Points, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.Points.CopyAssign(value);
			}
		}

		// Token: 0x170001C2 RID: 450
		// (get) Token: 0x060011E5 RID: 4581 RVA: 0x0001C62D File Offset: 0x0001A82D
		// (set) Token: 0x060011E6 RID: 4582 RVA: 0x0001C63D File Offset: 0x0001A83D
		public unsafe bool bIsLooped
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FInterpCurveQuat.__PropertyOffset_bIsLooped) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FInterpCurveQuat.__PropertyOffset_bIsLooped) = (value ? 1 : 0);
			}
		}

		// Token: 0x170001C3 RID: 451
		// (get) Token: 0x060011E7 RID: 4583 RVA: 0x0001C64E File Offset: 0x0001A84E
		// (set) Token: 0x060011E8 RID: 4584 RVA: 0x0001C65E File Offset: 0x0001A85E
		public unsafe float LoopKeyOffset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FInterpCurveQuat.__PropertyOffset_LoopKeyOffset);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FInterpCurveQuat.__PropertyOffset_LoopKeyOffset) = value;
			}
		}

		// Token: 0x060011E9 RID: 4585 RVA: 0x0001C66F File Offset: 0x0001A86F
		public FInterpCurveQuat()
		{
		}

		// Token: 0x060011EA RID: 4586 RVA: 0x0001C677 File Offset: 0x0001A877
		protected override IntPtr GetUStructPtr()
		{
			return FInterpCurveQuat.StaticStruct();
		}

		// Token: 0x060011EB RID: 4587 RVA: 0x0001C683 File Offset: 0x0001A883
		[NullableContext(2)]
		public FInterpCurveQuat(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060011EC RID: 4588 RVA: 0x0001C68D File Offset: 0x0001A88D
		public FInterpCurveQuat(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060011ED RID: 4589 RVA: 0x0001C698 File Offset: 0x0001A898
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FInterpCurveQuat(Pointer, false, true);
		}

		// Token: 0x060011EE RID: 4590 RVA: 0x0001C6A2 File Offset: 0x0001A8A2
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FInterpCurveQuat(Pointer, MemoryOwner);
		}

		// Token: 0x04000552 RID: 1362
		public const string __ObjectPath = "/Script/CoreUObject.InterpCurveQuat";

		// Token: 0x04000553 RID: 1363
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04000554 RID: 1364
		internal static int __PropertyOffset_Points;

		// Token: 0x04000555 RID: 1365
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FInterpCurvePointQuat> _Points;

		// Token: 0x04000556 RID: 1366
		internal static int __PropertyOffset_bIsLooped;

		// Token: 0x04000557 RID: 1367
		internal static int __PropertyOffset_LoopKeyOffset;
	}
}
