using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200023A RID: 570
	[UnrealObjectPath("/Script/AkAudio.AkReverbDescriptor")]
	[UnrealStructLayout(40, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 40)]
	public class FAkReverbDescriptor : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600213F RID: 8511 RVA: 0x000316CE File Offset: 0x0002F8CE
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FAkReverbDescriptor._ScriptStructPtr != 0) ? FAkReverbDescriptor._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/AkAudio.AkReverbDescriptor", ref FAkReverbDescriptor._ScriptStructPtr);
		}

		// Token: 0x17000805 RID: 2053
		// (get) Token: 0x06002140 RID: 8512 RVA: 0x000316F2 File Offset: 0x0002F8F2
		// (set) Token: 0x06002141 RID: 8513 RVA: 0x00031706 File Offset: 0x0002F906
		[Nullable(2)]
		public unsafe UPrimitiveComponent Primitive
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UPrimitiveComponent>(base.NativePtr / (IntPtr)sizeof(void*) + FAkReverbDescriptor.__PropertyOffset_Primitive);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FAkReverbDescriptor.__PropertyOffset_Primitive, value);
			}
		}

		// Token: 0x06002142 RID: 8514 RVA: 0x0003171B File Offset: 0x0002F91B
		public FAkReverbDescriptor()
		{
		}

		// Token: 0x06002143 RID: 8515 RVA: 0x00031723 File Offset: 0x0002F923
		[NullableContext(1)]
		public FAkReverbDescriptor(UPrimitiveComponent Primitive)
		{
			this.Primitive = Primitive;
		}

		// Token: 0x06002144 RID: 8516 RVA: 0x00031732 File Offset: 0x0002F932
		protected override IntPtr GetUStructPtr()
		{
			return FAkReverbDescriptor.StaticStruct();
		}

		// Token: 0x06002145 RID: 8517 RVA: 0x0003173E File Offset: 0x0002F93E
		[NullableContext(2)]
		public FAkReverbDescriptor(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06002146 RID: 8518 RVA: 0x00031748 File Offset: 0x0002F948
		public FAkReverbDescriptor(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06002147 RID: 8519 RVA: 0x00031753 File Offset: 0x0002F953
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FAkReverbDescriptor(Pointer, false, true);
		}

		// Token: 0x06002148 RID: 8520 RVA: 0x0003175D File Offset: 0x0002F95D
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FAkReverbDescriptor(Pointer, MemoryOwner);
		}

		// Token: 0x04000B3F RID: 2879
		[Nullable(1)]
		public const string __ObjectPath = "/Script/AkAudio.AkReverbDescriptor";

		// Token: 0x04000B40 RID: 2880
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04000B41 RID: 2881
		internal static int __PropertyOffset_Primitive;
	}
}
