using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000828 RID: 2088
	[UnrealObjectPath("/Script/Engine.AnimNotifyEventReference")]
	[UnrealStructLayout(32, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 32)]
	public class FAnimNotifyEventReference : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600706A RID: 28778 RVA: 0x000A13DC File Offset: 0x0009F5DC
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FAnimNotifyEventReference._ScriptStructPtr != 0) ? FAnimNotifyEventReference._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.AnimNotifyEventReference", ref FAnimNotifyEventReference._ScriptStructPtr);
		}

		// Token: 0x17001A76 RID: 6774
		// (get) Token: 0x0600706B RID: 28779 RVA: 0x000A1400 File Offset: 0x0009F600
		// (set) Token: 0x0600706C RID: 28780 RVA: 0x000A1414 File Offset: 0x0009F614
		[Nullable(2)]
		public unsafe UObject NotifySource
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UObject>(base.NativePtr / (IntPtr)sizeof(void*) + FAnimNotifyEventReference.__PropertyOffset_NotifySource);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FAnimNotifyEventReference.__PropertyOffset_NotifySource, value);
			}
		}

		// Token: 0x0600706D RID: 28781 RVA: 0x000A1429 File Offset: 0x0009F629
		public FAnimNotifyEventReference()
		{
		}

		// Token: 0x0600706E RID: 28782 RVA: 0x000A1431 File Offset: 0x0009F631
		[NullableContext(1)]
		public FAnimNotifyEventReference(UObject NotifySource)
		{
			this.NotifySource = NotifySource;
		}

		// Token: 0x0600706F RID: 28783 RVA: 0x000A1440 File Offset: 0x0009F640
		protected override IntPtr GetUStructPtr()
		{
			return FAnimNotifyEventReference.StaticStruct();
		}

		// Token: 0x06007070 RID: 28784 RVA: 0x000A144C File Offset: 0x0009F64C
		[NullableContext(2)]
		public FAnimNotifyEventReference(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06007071 RID: 28785 RVA: 0x000A1456 File Offset: 0x0009F656
		public FAnimNotifyEventReference(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06007072 RID: 28786 RVA: 0x000A1461 File Offset: 0x0009F661
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FAnimNotifyEventReference(Pointer, false, true);
		}

		// Token: 0x06007073 RID: 28787 RVA: 0x000A146B File Offset: 0x0009F66B
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FAnimNotifyEventReference(Pointer, MemoryOwner);
		}

		// Token: 0x040035FA RID: 13818
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.AnimNotifyEventReference";

		// Token: 0x040035FB RID: 13819
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040035FC RID: 13820
		internal static int __PropertyOffset_NotifySource;
	}
}
