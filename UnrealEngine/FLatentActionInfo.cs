using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000D1A RID: 3354
	[UnrealObjectPath("/Script/Engine.LatentActionInfo")]
	[UnrealStructLayout(32, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 32)]
	public class FLatentActionInfo : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600B3D4 RID: 46036 RVA: 0x001007CC File Offset: 0x000FE9CC
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FLatentActionInfo._ScriptStructPtr != 0) ? FLatentActionInfo._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.LatentActionInfo", ref FLatentActionInfo._ScriptStructPtr);
		}

		// Token: 0x1700291F RID: 10527
		// (get) Token: 0x0600B3D5 RID: 46037 RVA: 0x001007F0 File Offset: 0x000FE9F0
		// (set) Token: 0x0600B3D6 RID: 46038 RVA: 0x00100800 File Offset: 0x000FEA00
		public unsafe int Linkage
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FLatentActionInfo.__PropertyOffset_Linkage);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FLatentActionInfo.__PropertyOffset_Linkage) = value;
			}
		}

		// Token: 0x17002920 RID: 10528
		// (get) Token: 0x0600B3D7 RID: 46039 RVA: 0x00100811 File Offset: 0x000FEA11
		// (set) Token: 0x0600B3D8 RID: 46040 RVA: 0x00100821 File Offset: 0x000FEA21
		public unsafe int UUID
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FLatentActionInfo.__PropertyOffset_UUID);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FLatentActionInfo.__PropertyOffset_UUID) = value;
			}
		}

		// Token: 0x17002921 RID: 10529
		// (get) Token: 0x0600B3D9 RID: 46041 RVA: 0x00100832 File Offset: 0x000FEA32
		// (set) Token: 0x0600B3DA RID: 46042 RVA: 0x00100846 File Offset: 0x000FEA46
		public unsafe FName ExecutionFunction
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FLatentActionInfo.__PropertyOffset_ExecutionFunction);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FLatentActionInfo.__PropertyOffset_ExecutionFunction) = value;
			}
		}

		// Token: 0x17002922 RID: 10530
		// (get) Token: 0x0600B3DB RID: 46043 RVA: 0x0010085B File Offset: 0x000FEA5B
		// (set) Token: 0x0600B3DC RID: 46044 RVA: 0x0010086F File Offset: 0x000FEA6F
		[Nullable(2)]
		public unsafe UObject CallbackTarget
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UObject>(base.NativePtr / (IntPtr)sizeof(void*) + FLatentActionInfo.__PropertyOffset_CallbackTarget);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FLatentActionInfo.__PropertyOffset_CallbackTarget, value);
			}
		}

		// Token: 0x0600B3DD RID: 46045 RVA: 0x00100884 File Offset: 0x000FEA84
		public FLatentActionInfo()
		{
		}

		// Token: 0x0600B3DE RID: 46046 RVA: 0x0010088C File Offset: 0x000FEA8C
		[NullableContext(1)]
		public FLatentActionInfo(int Linkage, int UUID, FName ExecutionFunction, UObject CallbackTarget)
		{
			this.Linkage = Linkage;
			this.UUID = UUID;
			this.ExecutionFunction = ExecutionFunction;
			this.CallbackTarget = CallbackTarget;
		}

		// Token: 0x0600B3DF RID: 46047 RVA: 0x001008B1 File Offset: 0x000FEAB1
		protected override IntPtr GetUStructPtr()
		{
			return FLatentActionInfo.StaticStruct();
		}

		// Token: 0x0600B3E0 RID: 46048 RVA: 0x001008BD File Offset: 0x000FEABD
		[NullableContext(2)]
		public FLatentActionInfo(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600B3E1 RID: 46049 RVA: 0x001008C7 File Offset: 0x000FEAC7
		public FLatentActionInfo(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600B3E2 RID: 46050 RVA: 0x001008D2 File Offset: 0x000FEAD2
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FLatentActionInfo(Pointer, false, true);
		}

		// Token: 0x0600B3E3 RID: 46051 RVA: 0x001008DC File Offset: 0x000FEADC
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FLatentActionInfo(Pointer, MemoryOwner);
		}

		// Token: 0x04005E89 RID: 24201
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.LatentActionInfo";

		// Token: 0x04005E8A RID: 24202
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04005E8B RID: 24203
		internal static int __PropertyOffset_Linkage;

		// Token: 0x04005E8C RID: 24204
		internal static int __PropertyOffset_UUID;

		// Token: 0x04005E8D RID: 24205
		internal static int __PropertyOffset_ExecutionFunction;

		// Token: 0x04005E8E RID: 24206
		internal static int __PropertyOffset_CallbackTarget;
	}
}
