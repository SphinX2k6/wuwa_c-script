using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02002594 RID: 9620
	[UnrealObjectPath("/Script/Niagara.NiagaraDebugHudTextOptions")]
	[UnrealStructLayout(20, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 20)]
	public class FNiagaraDebugHudTextOptions : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06023B72 RID: 146290 RVA: 0x0034CFE0 File Offset: 0x0034B1E0
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FNiagaraDebugHudTextOptions._ScriptStructPtr != 0) ? FNiagaraDebugHudTextOptions._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Niagara.NiagaraDebugHudTextOptions", ref FNiagaraDebugHudTextOptions._ScriptStructPtr);
		}

		// Token: 0x17008931 RID: 35121
		// (get) Token: 0x06023B73 RID: 146291 RVA: 0x0034D004 File Offset: 0x0034B204
		// (set) Token: 0x06023B74 RID: 146292 RVA: 0x0034D014 File Offset: 0x0034B214
		public unsafe ENiagaraDebugHudFont Font
		{
			get
			{
				return (ENiagaraDebugHudFont)(*(base.NativePtr + (IntPtr)FNiagaraDebugHudTextOptions.__PropertyOffset_Font));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FNiagaraDebugHudTextOptions.__PropertyOffset_Font) = (int)value;
			}
		}

		// Token: 0x17008932 RID: 35122
		// (get) Token: 0x06023B75 RID: 146293 RVA: 0x0034D025 File Offset: 0x0034B225
		// (set) Token: 0x06023B76 RID: 146294 RVA: 0x0034D035 File Offset: 0x0034B235
		public unsafe ENiagaraDebugHudHAlign HorizontalAlignment
		{
			get
			{
				return (ENiagaraDebugHudHAlign)(*(base.NativePtr + (IntPtr)FNiagaraDebugHudTextOptions.__PropertyOffset_HorizontalAlignment));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FNiagaraDebugHudTextOptions.__PropertyOffset_HorizontalAlignment) = (int)value;
			}
		}

		// Token: 0x17008933 RID: 35123
		// (get) Token: 0x06023B77 RID: 146295 RVA: 0x0034D046 File Offset: 0x0034B246
		// (set) Token: 0x06023B78 RID: 146296 RVA: 0x0034D056 File Offset: 0x0034B256
		public unsafe ENiagaraDebugHudVAlign VerticalAlignment
		{
			get
			{
				return (ENiagaraDebugHudVAlign)(*(base.NativePtr + (IntPtr)FNiagaraDebugHudTextOptions.__PropertyOffset_VerticalAlignment));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FNiagaraDebugHudTextOptions.__PropertyOffset_VerticalAlignment) = (int)value;
			}
		}

		// Token: 0x17008934 RID: 35124
		// (get) Token: 0x06023B79 RID: 146297 RVA: 0x0034D067 File Offset: 0x0034B267
		// (set) Token: 0x06023B7A RID: 146298 RVA: 0x0034D07B File Offset: 0x0034B27B
		public unsafe FVector2D ScreenOffset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FNiagaraDebugHudTextOptions.__PropertyOffset_ScreenOffset);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FNiagaraDebugHudTextOptions.__PropertyOffset_ScreenOffset) = value;
			}
		}

		// Token: 0x06023B7B RID: 146299 RVA: 0x0034D090 File Offset: 0x0034B290
		public FNiagaraDebugHudTextOptions()
		{
		}

		// Token: 0x06023B7C RID: 146300 RVA: 0x0034D098 File Offset: 0x0034B298
		public FNiagaraDebugHudTextOptions(ENiagaraDebugHudFont Font, ENiagaraDebugHudHAlign HorizontalAlignment, ENiagaraDebugHudVAlign VerticalAlignment, FVector2D ScreenOffset)
		{
			this.Font = Font;
			this.HorizontalAlignment = HorizontalAlignment;
			this.VerticalAlignment = VerticalAlignment;
			this.ScreenOffset = ScreenOffset;
		}

		// Token: 0x06023B7D RID: 146301 RVA: 0x0034D0BD File Offset: 0x0034B2BD
		protected override IntPtr GetUStructPtr()
		{
			return FNiagaraDebugHudTextOptions.StaticStruct();
		}

		// Token: 0x06023B7E RID: 146302 RVA: 0x0034D0C9 File Offset: 0x0034B2C9
		[NullableContext(2)]
		public FNiagaraDebugHudTextOptions(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06023B7F RID: 146303 RVA: 0x0034D0D3 File Offset: 0x0034B2D3
		public FNiagaraDebugHudTextOptions(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06023B80 RID: 146304 RVA: 0x0034D0DE File Offset: 0x0034B2DE
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FNiagaraDebugHudTextOptions(Pointer, false, true);
		}

		// Token: 0x06023B81 RID: 146305 RVA: 0x0034D0E8 File Offset: 0x0034B2E8
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FNiagaraDebugHudTextOptions(Pointer, MemoryOwner);
		}

		// Token: 0x04013273 RID: 78451
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Niagara.NiagaraDebugHudTextOptions";

		// Token: 0x04013274 RID: 78452
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04013275 RID: 78453
		internal static int __PropertyOffset_Font;

		// Token: 0x04013276 RID: 78454
		internal static int __PropertyOffset_HorizontalAlignment;

		// Token: 0x04013277 RID: 78455
		internal static int __PropertyOffset_VerticalAlignment;

		// Token: 0x04013278 RID: 78456
		internal static int __PropertyOffset_ScreenOffset;
	}
}
