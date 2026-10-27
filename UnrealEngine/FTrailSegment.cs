using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001942 RID: 6466
	[UnrealObjectPath("/Script/KuroGameplay.TrailSegment")]
	[UnrealStructLayout(40, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 40)]
	public class FTrailSegment : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06017F6F RID: 98159 RVA: 0x00232310 File Offset: 0x00230510
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FTrailSegment._ScriptStructPtr != 0) ? FTrailSegment._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroGameplay.TrailSegment", ref FTrailSegment._ScriptStructPtr);
		}

		// Token: 0x1700600A RID: 24586
		// (get) Token: 0x06017F70 RID: 98160 RVA: 0x00232334 File Offset: 0x00230534
		// (set) Token: 0x06017F71 RID: 98161 RVA: 0x00232348 File Offset: 0x00230548
		[Nullable(2)]
		public unsafe UBoxComponent Box
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UBoxComponent>(base.NativePtr / (IntPtr)sizeof(void*) + FTrailSegment.__PropertyOffset_Box);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FTrailSegment.__PropertyOffset_Box, value);
			}
		}

		// Token: 0x06017F72 RID: 98162 RVA: 0x0023235D File Offset: 0x0023055D
		public FTrailSegment()
		{
		}

		// Token: 0x06017F73 RID: 98163 RVA: 0x00232365 File Offset: 0x00230565
		[NullableContext(1)]
		public FTrailSegment(UBoxComponent Box)
		{
			this.Box = Box;
		}

		// Token: 0x06017F74 RID: 98164 RVA: 0x00232374 File Offset: 0x00230574
		protected override IntPtr GetUStructPtr()
		{
			return FTrailSegment.StaticStruct();
		}

		// Token: 0x06017F75 RID: 98165 RVA: 0x00232380 File Offset: 0x00230580
		[NullableContext(2)]
		public FTrailSegment(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06017F76 RID: 98166 RVA: 0x0023238A File Offset: 0x0023058A
		public FTrailSegment(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06017F77 RID: 98167 RVA: 0x00232395 File Offset: 0x00230595
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FTrailSegment(Pointer, false, true);
		}

		// Token: 0x06017F78 RID: 98168 RVA: 0x0023239F File Offset: 0x0023059F
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FTrailSegment(Pointer, MemoryOwner);
		}

		// Token: 0x0400CF6F RID: 53103
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroGameplay.TrailSegment";

		// Token: 0x0400CF70 RID: 53104
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400CF71 RID: 53105
		internal static int __PropertyOffset_Box;
	}
}
