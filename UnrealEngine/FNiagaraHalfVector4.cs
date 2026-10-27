using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020025B1 RID: 9649
	[UnrealObjectPath("/Script/Niagara.NiagaraHalfVector4")]
	[UnrealStructLayout(8, 2, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 8)]
	public class FNiagaraHalfVector4 : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06023D83 RID: 146819 RVA: 0x00350174 File Offset: 0x0034E374
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FNiagaraHalfVector4._ScriptStructPtr != 0) ? FNiagaraHalfVector4._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Niagara.NiagaraHalfVector4", ref FNiagaraHalfVector4._ScriptStructPtr);
		}

		// Token: 0x170089C1 RID: 35265
		// (get) Token: 0x06023D84 RID: 146820 RVA: 0x00350198 File Offset: 0x0034E398
		// (set) Token: 0x06023D85 RID: 146821 RVA: 0x003501A8 File Offset: 0x0034E3A8
		public unsafe ushort x
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FNiagaraHalfVector4.__PropertyOffset_x);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FNiagaraHalfVector4.__PropertyOffset_x) = (short)value;
			}
		}

		// Token: 0x170089C2 RID: 35266
		// (get) Token: 0x06023D86 RID: 146822 RVA: 0x003501B9 File Offset: 0x0034E3B9
		// (set) Token: 0x06023D87 RID: 146823 RVA: 0x003501C9 File Offset: 0x0034E3C9
		public unsafe ushort y
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FNiagaraHalfVector4.__PropertyOffset_y);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FNiagaraHalfVector4.__PropertyOffset_y) = (short)value;
			}
		}

		// Token: 0x170089C3 RID: 35267
		// (get) Token: 0x06023D88 RID: 146824 RVA: 0x003501DA File Offset: 0x0034E3DA
		// (set) Token: 0x06023D89 RID: 146825 RVA: 0x003501EA File Offset: 0x0034E3EA
		public unsafe ushort z
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FNiagaraHalfVector4.__PropertyOffset_z);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FNiagaraHalfVector4.__PropertyOffset_z) = (short)value;
			}
		}

		// Token: 0x170089C4 RID: 35268
		// (get) Token: 0x06023D8A RID: 146826 RVA: 0x003501FB File Offset: 0x0034E3FB
		// (set) Token: 0x06023D8B RID: 146827 RVA: 0x0035020B File Offset: 0x0034E40B
		public unsafe ushort w
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FNiagaraHalfVector4.__PropertyOffset_w);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FNiagaraHalfVector4.__PropertyOffset_w) = (short)value;
			}
		}

		// Token: 0x06023D8C RID: 146828 RVA: 0x0035021C File Offset: 0x0034E41C
		public FNiagaraHalfVector4()
		{
		}

		// Token: 0x06023D8D RID: 146829 RVA: 0x00350224 File Offset: 0x0034E424
		public FNiagaraHalfVector4(ushort x, ushort y, ushort z, ushort w)
		{
			this.x = x;
			this.y = y;
			this.z = z;
			this.w = w;
		}

		// Token: 0x06023D8E RID: 146830 RVA: 0x00350249 File Offset: 0x0034E449
		protected override IntPtr GetUStructPtr()
		{
			return FNiagaraHalfVector4.StaticStruct();
		}

		// Token: 0x06023D8F RID: 146831 RVA: 0x00350255 File Offset: 0x0034E455
		[NullableContext(2)]
		public FNiagaraHalfVector4(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06023D90 RID: 146832 RVA: 0x0035025F File Offset: 0x0034E45F
		public FNiagaraHalfVector4(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06023D91 RID: 146833 RVA: 0x0035026A File Offset: 0x0034E46A
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FNiagaraHalfVector4(Pointer, false, true);
		}

		// Token: 0x06023D92 RID: 146834 RVA: 0x00350274 File Offset: 0x0034E474
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FNiagaraHalfVector4(Pointer, MemoryOwner);
		}

		// Token: 0x0401337E RID: 78718
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Niagara.NiagaraHalfVector4";

		// Token: 0x0401337F RID: 78719
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04013380 RID: 78720
		internal static int __PropertyOffset_x;

		// Token: 0x04013381 RID: 78721
		internal static int __PropertyOffset_y;

		// Token: 0x04013382 RID: 78722
		internal static int __PropertyOffset_z;

		// Token: 0x04013383 RID: 78723
		internal static int __PropertyOffset_w;
	}
}
