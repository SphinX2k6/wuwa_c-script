using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020025AD RID: 9645
	[UnrealObjectPath("/Script/Niagara.NiagaraGraphViewSettings")]
	[UnrealStructLayout(16, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 16)]
	public class FNiagaraGraphViewSettings : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06023D51 RID: 146769 RVA: 0x0034FE64 File Offset: 0x0034E064
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FNiagaraGraphViewSettings._ScriptStructPtr != 0) ? FNiagaraGraphViewSettings._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Niagara.NiagaraGraphViewSettings", ref FNiagaraGraphViewSettings._ScriptStructPtr);
		}

		// Token: 0x170089B8 RID: 35256
		// (get) Token: 0x06023D52 RID: 146770 RVA: 0x0034FE88 File Offset: 0x0034E088
		// (set) Token: 0x06023D53 RID: 146771 RVA: 0x0034FE9C File Offset: 0x0034E09C
		public unsafe FVector2D Location
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FNiagaraGraphViewSettings.__PropertyOffset_Location);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FNiagaraGraphViewSettings.__PropertyOffset_Location) = value;
			}
		}

		// Token: 0x170089B9 RID: 35257
		// (get) Token: 0x06023D54 RID: 146772 RVA: 0x0034FEB1 File Offset: 0x0034E0B1
		// (set) Token: 0x06023D55 RID: 146773 RVA: 0x0034FEC1 File Offset: 0x0034E0C1
		public unsafe float Zoom
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FNiagaraGraphViewSettings.__PropertyOffset_Zoom);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FNiagaraGraphViewSettings.__PropertyOffset_Zoom) = value;
			}
		}

		// Token: 0x170089BA RID: 35258
		// (get) Token: 0x06023D56 RID: 146774 RVA: 0x0034FED2 File Offset: 0x0034E0D2
		// (set) Token: 0x06023D57 RID: 146775 RVA: 0x0034FEE2 File Offset: 0x0034E0E2
		public unsafe bool bIsValid
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FNiagaraGraphViewSettings.__PropertyOffset_bIsValid) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FNiagaraGraphViewSettings.__PropertyOffset_bIsValid) = (value ? 1 : 0);
			}
		}

		// Token: 0x06023D58 RID: 146776 RVA: 0x0034FEF3 File Offset: 0x0034E0F3
		public FNiagaraGraphViewSettings()
		{
		}

		// Token: 0x06023D59 RID: 146777 RVA: 0x0034FEFB File Offset: 0x0034E0FB
		public FNiagaraGraphViewSettings(FVector2D Location, float Zoom, bool bIsValid)
		{
			this.Location = Location;
			this.Zoom = Zoom;
			this.bIsValid = bIsValid;
		}

		// Token: 0x06023D5A RID: 146778 RVA: 0x0034FF18 File Offset: 0x0034E118
		protected override IntPtr GetUStructPtr()
		{
			return FNiagaraGraphViewSettings.StaticStruct();
		}

		// Token: 0x06023D5B RID: 146779 RVA: 0x0034FF24 File Offset: 0x0034E124
		[NullableContext(2)]
		public FNiagaraGraphViewSettings(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06023D5C RID: 146780 RVA: 0x0034FF2E File Offset: 0x0034E12E
		public FNiagaraGraphViewSettings(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06023D5D RID: 146781 RVA: 0x0034FF39 File Offset: 0x0034E139
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FNiagaraGraphViewSettings(Pointer, false, true);
		}

		// Token: 0x06023D5E RID: 146782 RVA: 0x0034FF43 File Offset: 0x0034E143
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FNiagaraGraphViewSettings(Pointer, MemoryOwner);
		}

		// Token: 0x0401336D RID: 78701
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Niagara.NiagaraGraphViewSettings";

		// Token: 0x0401336E RID: 78702
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0401336F RID: 78703
		internal static int __PropertyOffset_Location;

		// Token: 0x04013370 RID: 78704
		internal static int __PropertyOffset_Zoom;

		// Token: 0x04013371 RID: 78705
		internal static int __PropertyOffset_bIsValid;
	}
}
