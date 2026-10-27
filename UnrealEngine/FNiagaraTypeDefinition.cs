using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020025FA RID: 9722
	[HasGetTypeHash]
	[UnrealObjectPath("/Script/Niagara.NiagaraTypeDefinition")]
	[UnrealStructLayout(32, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 32)]
	public class FNiagaraTypeDefinition : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06024294 RID: 148116 RVA: 0x003586C2 File Offset: 0x003568C2
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FNiagaraTypeDefinition._ScriptStructPtr != 0) ? FNiagaraTypeDefinition._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Niagara.NiagaraTypeDefinition", ref FNiagaraTypeDefinition._ScriptStructPtr);
		}

		// Token: 0x17008B45 RID: 35653
		// (get) Token: 0x06024295 RID: 148117 RVA: 0x003586E6 File Offset: 0x003568E6
		// (set) Token: 0x06024296 RID: 148118 RVA: 0x003586FA File Offset: 0x003568FA
		[Nullable(2)]
		public unsafe UObject ClassStructOrEnum
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UObject>(base.NativePtr / (IntPtr)sizeof(void*) + FNiagaraTypeDefinition.__PropertyOffset_ClassStructOrEnum);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FNiagaraTypeDefinition.__PropertyOffset_ClassStructOrEnum, value);
			}
		}

		// Token: 0x17008B46 RID: 35654
		// (get) Token: 0x06024297 RID: 148119 RVA: 0x0035870F File Offset: 0x0035690F
		// (set) Token: 0x06024298 RID: 148120 RVA: 0x0035871F File Offset: 0x0035691F
		public unsafe ushort UnderlyingType
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FNiagaraTypeDefinition.__PropertyOffset_UnderlyingType);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FNiagaraTypeDefinition.__PropertyOffset_UnderlyingType) = (short)value;
			}
		}

		// Token: 0x06024299 RID: 148121 RVA: 0x00358730 File Offset: 0x00356930
		public FNiagaraTypeDefinition()
		{
		}

		// Token: 0x0602429A RID: 148122 RVA: 0x00358738 File Offset: 0x00356938
		[NullableContext(1)]
		public FNiagaraTypeDefinition(UObject ClassStructOrEnum, ushort UnderlyingType, UStruct Struct_DEPRECATED, UEnum Enum_DEPRECATED)
		{
			this.ClassStructOrEnum = ClassStructOrEnum;
			this.UnderlyingType = UnderlyingType;
		}

		// Token: 0x0602429B RID: 148123 RVA: 0x0035874E File Offset: 0x0035694E
		protected override IntPtr GetUStructPtr()
		{
			return FNiagaraTypeDefinition.StaticStruct();
		}

		// Token: 0x0602429C RID: 148124 RVA: 0x0035875A File Offset: 0x0035695A
		[NullableContext(2)]
		public FNiagaraTypeDefinition(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0602429D RID: 148125 RVA: 0x00358764 File Offset: 0x00356964
		public FNiagaraTypeDefinition(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0602429E RID: 148126 RVA: 0x0035876F File Offset: 0x0035696F
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FNiagaraTypeDefinition(Pointer, false, true);
		}

		// Token: 0x0602429F RID: 148127 RVA: 0x00358779 File Offset: 0x00356979
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FNiagaraTypeDefinition(Pointer, MemoryOwner);
		}

		// Token: 0x04013674 RID: 79476
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Niagara.NiagaraTypeDefinition";

		// Token: 0x04013675 RID: 79477
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04013676 RID: 79478
		internal static int __PropertyOffset_ClassStructOrEnum;

		// Token: 0x04013677 RID: 79479
		internal static int __PropertyOffset_UnderlyingType;
	}
}
