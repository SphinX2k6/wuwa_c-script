using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020007A0 RID: 1952
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Niagara.NiagaraAssetInfoEntry")]
	[UnrealStructLayout(56, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 56)]
	public class FNiagaraAssetInfoEntry : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600A908 RID: 43272 RVA: 0x000F9CC4 File Offset: 0x000F7EC4
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FNiagaraAssetInfoEntry._ScriptStructPtr != 0) ? FNiagaraAssetInfoEntry._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Niagara.NiagaraAssetInfoEntry", ref FNiagaraAssetInfoEntry._ScriptStructPtr);
		}

		// Token: 0x17001F93 RID: 8083
		// (get) Token: 0x0600A909 RID: 43273 RVA: 0x000F9CE8 File Offset: 0x000F7EE8
		// (set) Token: 0x0600A90A RID: 43274 RVA: 0x000F9CFC File Offset: 0x000F7EFC
		public unsafe string AssetName
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FNiagaraAssetInfoEntry.__PropertyOffset_AssetName)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FNiagaraAssetInfoEntry.__PropertyOffset_AssetName)), value);
			}
		}

		// Token: 0x17001F94 RID: 8084
		// (get) Token: 0x0600A90B RID: 43275 RVA: 0x000F9D11 File Offset: 0x000F7F11
		// (set) Token: 0x0600A90C RID: 43276 RVA: 0x000F9D25 File Offset: 0x000F7F25
		public unsafe string AssetPath
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FNiagaraAssetInfoEntry.__PropertyOffset_AssetPath)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FNiagaraAssetInfoEntry.__PropertyOffset_AssetPath)), value);
			}
		}

		// Token: 0x17001F95 RID: 8085
		// (get) Token: 0x0600A90D RID: 43277 RVA: 0x000F9D3A File Offset: 0x000F7F3A
		// (set) Token: 0x0600A90E RID: 43278 RVA: 0x000F9D4A File Offset: 0x000F7F4A
		public unsafe int Particles
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FNiagaraAssetInfoEntry.__PropertyOffset_Particles);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FNiagaraAssetInfoEntry.__PropertyOffset_Particles) = value;
			}
		}

		// Token: 0x17001F96 RID: 8086
		// (get) Token: 0x0600A90F RID: 43279 RVA: 0x000F9D5B File Offset: 0x000F7F5B
		// (set) Token: 0x0600A910 RID: 43280 RVA: 0x000F9D6B File Offset: 0x000F7F6B
		public unsafe int Emitters
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FNiagaraAssetInfoEntry.__PropertyOffset_Emitters);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FNiagaraAssetInfoEntry.__PropertyOffset_Emitters) = value;
			}
		}

		// Token: 0x17001F97 RID: 8087
		// (get) Token: 0x0600A911 RID: 43281 RVA: 0x000F9D7C File Offset: 0x000F7F7C
		// (set) Token: 0x0600A912 RID: 43282 RVA: 0x000F9D8C File Offset: 0x000F7F8C
		public unsafe int ActiveInstances
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FNiagaraAssetInfoEntry.__PropertyOffset_ActiveInstances);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FNiagaraAssetInfoEntry.__PropertyOffset_ActiveInstances) = value;
			}
		}

		// Token: 0x17001F98 RID: 8088
		// (get) Token: 0x0600A913 RID: 43283 RVA: 0x000F9D9D File Offset: 0x000F7F9D
		// (set) Token: 0x0600A914 RID: 43284 RVA: 0x000F9DAD File Offset: 0x000F7FAD
		public unsafe int ScalabilityInstances
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FNiagaraAssetInfoEntry.__PropertyOffset_ScalabilityInstances);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FNiagaraAssetInfoEntry.__PropertyOffset_ScalabilityInstances) = value;
			}
		}

		// Token: 0x17001F99 RID: 8089
		// (get) Token: 0x0600A915 RID: 43285 RVA: 0x000F9DBE File Offset: 0x000F7FBE
		// (set) Token: 0x0600A916 RID: 43286 RVA: 0x000F9DCE File Offset: 0x000F7FCE
		public unsafe int TotalInstances
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FNiagaraAssetInfoEntry.__PropertyOffset_TotalInstances);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FNiagaraAssetInfoEntry.__PropertyOffset_TotalInstances) = value;
			}
		}

		// Token: 0x0600A917 RID: 43287 RVA: 0x000F9DDF File Offset: 0x000F7FDF
		public FNiagaraAssetInfoEntry()
		{
		}

		// Token: 0x0600A918 RID: 43288 RVA: 0x000F9DE7 File Offset: 0x000F7FE7
		protected override IntPtr GetUStructPtr()
		{
			return FNiagaraAssetInfoEntry.StaticStruct();
		}

		// Token: 0x0600A919 RID: 43289 RVA: 0x000F9DF3 File Offset: 0x000F7FF3
		[NullableContext(2)]
		public FNiagaraAssetInfoEntry(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600A91A RID: 43290 RVA: 0x000F9DFD File Offset: 0x000F7FFD
		public FNiagaraAssetInfoEntry(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600A91B RID: 43291 RVA: 0x000F9E08 File Offset: 0x000F8008
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FNiagaraAssetInfoEntry(Pointer, false, true);
		}

		// Token: 0x0600A91C RID: 43292 RVA: 0x000F9E12 File Offset: 0x000F8012
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FNiagaraAssetInfoEntry(Pointer, MemoryOwner);
		}

		// Token: 0x040048AD RID: 18605
		public const string __ObjectPath = "/Script/Niagara.NiagaraAssetInfoEntry";

		// Token: 0x040048AE RID: 18606
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040048AF RID: 18607
		internal static int __PropertyOffset_AssetName;

		// Token: 0x040048B0 RID: 18608
		internal static int __PropertyOffset_AssetPath;

		// Token: 0x040048B1 RID: 18609
		internal static int __PropertyOffset_Particles;

		// Token: 0x040048B2 RID: 18610
		internal static int __PropertyOffset_Emitters;

		// Token: 0x040048B3 RID: 18611
		internal static int __PropertyOffset_ActiveInstances;

		// Token: 0x040048B4 RID: 18612
		internal static int __PropertyOffset_ScalabilityInstances;

		// Token: 0x040048B5 RID: 18613
		internal static int __PropertyOffset_TotalInstances;
	}
}
