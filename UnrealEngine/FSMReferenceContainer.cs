using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200288F RID: 10383
	[UnrealObjectPath("/Script/SMSystem.SMReferenceContainer")]
	[UnrealStructLayout(24, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 24)]
	public class FSMReferenceContainer : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06026773 RID: 157555 RVA: 0x003A90CC File Offset: 0x003A72CC
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FSMReferenceContainer._ScriptStructPtr != 0) ? FSMReferenceContainer._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/SMSystem.SMReferenceContainer", ref FSMReferenceContainer._ScriptStructPtr);
		}

		// Token: 0x1700944B RID: 37963
		// (get) Token: 0x06026774 RID: 157556 RVA: 0x003A90F0 File Offset: 0x003A72F0
		// (set) Token: 0x06026775 RID: 157557 RVA: 0x003A9104 File Offset: 0x003A7304
		public unsafe FGuid PathGuid
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FSMReferenceContainer.__PropertyOffset_PathGuid);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FSMReferenceContainer.__PropertyOffset_PathGuid) = value;
			}
		}

		// Token: 0x1700944C RID: 37964
		// (get) Token: 0x06026776 RID: 157558 RVA: 0x003A9119 File Offset: 0x003A7319
		// (set) Token: 0x06026777 RID: 157559 RVA: 0x003A912D File Offset: 0x003A732D
		[Nullable(2)]
		public unsafe USMInstance Reference
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USMInstance>(base.NativePtr / (IntPtr)sizeof(void*) + FSMReferenceContainer.__PropertyOffset_Reference);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FSMReferenceContainer.__PropertyOffset_Reference, value);
			}
		}

		// Token: 0x06026778 RID: 157560 RVA: 0x003A9142 File Offset: 0x003A7342
		public FSMReferenceContainer()
		{
		}

		// Token: 0x06026779 RID: 157561 RVA: 0x003A914A File Offset: 0x003A734A
		[NullableContext(1)]
		public FSMReferenceContainer(FGuid PathGuid, USMInstance Reference)
		{
			this.PathGuid = PathGuid;
			this.Reference = Reference;
		}

		// Token: 0x0602677A RID: 157562 RVA: 0x003A9160 File Offset: 0x003A7360
		protected override IntPtr GetUStructPtr()
		{
			return FSMReferenceContainer.StaticStruct();
		}

		// Token: 0x0602677B RID: 157563 RVA: 0x003A916C File Offset: 0x003A736C
		[NullableContext(2)]
		public FSMReferenceContainer(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0602677C RID: 157564 RVA: 0x003A9176 File Offset: 0x003A7376
		public FSMReferenceContainer(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0602677D RID: 157565 RVA: 0x003A9181 File Offset: 0x003A7381
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FSMReferenceContainer(Pointer, false, true);
		}

		// Token: 0x0602677E RID: 157566 RVA: 0x003A918B File Offset: 0x003A738B
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FSMReferenceContainer(Pointer, MemoryOwner);
		}

		// Token: 0x040151C4 RID: 86468
		[Nullable(1)]
		public const string __ObjectPath = "/Script/SMSystem.SMReferenceContainer";

		// Token: 0x040151C5 RID: 86469
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040151C6 RID: 86470
		internal static int __PropertyOffset_PathGuid;

		// Token: 0x040151C7 RID: 86471
		internal static int __PropertyOffset_Reference;
	}
}
