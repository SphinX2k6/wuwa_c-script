using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001FC9 RID: 8137
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/LGUI.AnchorInfo")]
	[UnrealStructLayout(32, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 32)]
	public class FAnchorInfo : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601EDE6 RID: 126438 RVA: 0x002DE013 File Offset: 0x002DC213
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FAnchorInfo._ScriptStructPtr != 0) ? FAnchorInfo._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/LGUI.AnchorInfo", ref FAnchorInfo._ScriptStructPtr);
		}

		// Token: 0x17007AD7 RID: 31447
		// (get) Token: 0x0601EDE7 RID: 126439 RVA: 0x002DE037 File Offset: 0x002DC237
		// (set) Token: 0x0601EDE8 RID: 126440 RVA: 0x002DE04B File Offset: 0x002DC24B
		[Nullable(2)]
		public unsafe AUIBaseActor TargetActor
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<AUIBaseActor>(base.NativePtr / (IntPtr)sizeof(void*) + FAnchorInfo.__PropertyOffset_TargetActor);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FAnchorInfo.__PropertyOffset_TargetActor, value);
			}
		}

		// Token: 0x17007AD8 RID: 31448
		// (get) Token: 0x0601EDE9 RID: 126441 RVA: 0x002DE060 File Offset: 0x002DC260
		// (set) Token: 0x0601EDEA RID: 126442 RVA: 0x002DE074 File Offset: 0x002DC274
		public unsafe string AnchorBone
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FAnchorInfo.__PropertyOffset_AnchorBone)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FAnchorInfo.__PropertyOffset_AnchorBone)), value);
			}
		}

		// Token: 0x17007AD9 RID: 31449
		// (get) Token: 0x0601EDEB RID: 126443 RVA: 0x002DE089 File Offset: 0x002DC289
		// (set) Token: 0x0601EDEC RID: 126444 RVA: 0x002DE09D File Offset: 0x002DC29D
		public unsafe FVector2D Offset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnchorInfo.__PropertyOffset_Offset);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnchorInfo.__PropertyOffset_Offset) = value;
			}
		}

		// Token: 0x0601EDED RID: 126445 RVA: 0x002DE0B2 File Offset: 0x002DC2B2
		public FAnchorInfo()
		{
		}

		// Token: 0x0601EDEE RID: 126446 RVA: 0x002DE0BA File Offset: 0x002DC2BA
		public FAnchorInfo(AUIBaseActor TargetActor, string AnchorBone, FVector2D Offset)
		{
			this.TargetActor = TargetActor;
			this.AnchorBone = AnchorBone;
			this.Offset = Offset;
		}

		// Token: 0x0601EDEF RID: 126447 RVA: 0x002DE0D7 File Offset: 0x002DC2D7
		protected override IntPtr GetUStructPtr()
		{
			return FAnchorInfo.StaticStruct();
		}

		// Token: 0x0601EDF0 RID: 126448 RVA: 0x002DE0E3 File Offset: 0x002DC2E3
		[NullableContext(2)]
		public FAnchorInfo(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601EDF1 RID: 126449 RVA: 0x002DE0ED File Offset: 0x002DC2ED
		public FAnchorInfo(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601EDF2 RID: 126450 RVA: 0x002DE0F8 File Offset: 0x002DC2F8
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FAnchorInfo(Pointer, false, true);
		}

		// Token: 0x0601EDF3 RID: 126451 RVA: 0x002DE102 File Offset: 0x002DC302
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FAnchorInfo(Pointer, MemoryOwner);
		}

		// Token: 0x04010AD4 RID: 68308
		public const string __ObjectPath = "/Script/LGUI.AnchorInfo";

		// Token: 0x04010AD5 RID: 68309
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04010AD6 RID: 68310
		internal static int __PropertyOffset_TargetActor;

		// Token: 0x04010AD7 RID: 68311
		internal static int __PropertyOffset_AnchorBone;

		// Token: 0x04010AD8 RID: 68312
		internal static int __PropertyOffset_Offset;
	}
}
