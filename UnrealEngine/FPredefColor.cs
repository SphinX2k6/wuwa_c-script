using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020020FA RID: 8442
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/LGUI.PredefColor")]
	[UnrealStructLayout(32, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 32)]
	public class FPredefColor : FTableRowBase, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601FC55 RID: 130133 RVA: 0x002F3FE7 File Offset: 0x002F21E7
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FPredefColor._ScriptStructPtr != 0) ? FPredefColor._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/LGUI.PredefColor", ref FPredefColor._ScriptStructPtr);
		}

		// Token: 0x17007D02 RID: 32002
		// (get) Token: 0x0601FC56 RID: 130134 RVA: 0x002F400B File Offset: 0x002F220B
		// (set) Token: 0x0601FC57 RID: 130135 RVA: 0x002F401F File Offset: 0x002F221F
		public unsafe FColor Color
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPredefColor.__PropertyOffset_Color);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPredefColor.__PropertyOffset_Color) = value;
			}
		}

		// Token: 0x17007D03 RID: 32003
		// (get) Token: 0x0601FC58 RID: 130136 RVA: 0x002F4034 File Offset: 0x002F2234
		// (set) Token: 0x0601FC59 RID: 130137 RVA: 0x002F4048 File Offset: 0x002F2248
		public unsafe string Comment
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FPredefColor.__PropertyOffset_Comment)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FPredefColor.__PropertyOffset_Comment)), value);
			}
		}

		// Token: 0x0601FC5A RID: 130138 RVA: 0x002F405D File Offset: 0x002F225D
		public FPredefColor()
		{
		}

		// Token: 0x0601FC5B RID: 130139 RVA: 0x002F4065 File Offset: 0x002F2265
		public FPredefColor(FColor Color, string Comment)
		{
			this.Color = Color;
			this.Comment = Comment;
		}

		// Token: 0x0601FC5C RID: 130140 RVA: 0x002F407B File Offset: 0x002F227B
		protected override IntPtr GetUStructPtr()
		{
			return FPredefColor.StaticStruct();
		}

		// Token: 0x0601FC5D RID: 130141 RVA: 0x002F4087 File Offset: 0x002F2287
		[NullableContext(2)]
		public FPredefColor(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601FC5E RID: 130142 RVA: 0x002F4091 File Offset: 0x002F2291
		public FPredefColor(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601FC5F RID: 130143 RVA: 0x002F409C File Offset: 0x002F229C
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FPredefColor(Pointer, false, true);
		}

		// Token: 0x0601FC60 RID: 130144 RVA: 0x002F40A6 File Offset: 0x002F22A6
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FPredefColor(Pointer, MemoryOwner);
		}

		// Token: 0x040111FC RID: 70140
		public new const string __ObjectPath = "/Script/LGUI.PredefColor";

		// Token: 0x040111FD RID: 70141
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040111FE RID: 70142
		internal static int __PropertyOffset_Color;

		// Token: 0x040111FF RID: 70143
		internal static int __PropertyOffset_Comment;
	}
}
