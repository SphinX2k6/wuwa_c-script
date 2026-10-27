using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02002761 RID: 10081
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Sharphereal.KooSharpMonoTraceMaskRuntimeSettings")]
	[UnrealStructLayout(128, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 128)]
	public class FKooSharpMonoTraceMaskRuntimeSettings : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06025AFB RID: 154363 RVA: 0x00391C31 File Offset: 0x0038FE31
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FKooSharpMonoTraceMaskRuntimeSettings._ScriptStructPtr != 0) ? FKooSharpMonoTraceMaskRuntimeSettings._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Sharphereal.KooSharpMonoTraceMaskRuntimeSettings", ref FKooSharpMonoTraceMaskRuntimeSettings._ScriptStructPtr);
		}

		// Token: 0x17009111 RID: 37137
		// (get) Token: 0x06025AFC RID: 154364 RVA: 0x00391C58 File Offset: 0x0038FE58
		// (set) Token: 0x06025AFD RID: 154365 RVA: 0x00391C9B File Offset: 0x0038FE9B
		public TArray<EKooSharpMonoTraceMask> Debug
		{
			get
			{
				base.FastCheckIsValid();
				TArray<EKooSharpMonoTraceMask> result;
				if ((result = this._Debug) == null)
				{
					result = (this._Debug = new TArray<EKooSharpMonoTraceMask>(base.NativePtr + (IntPtr)FKooSharpMonoTraceMaskRuntimeSettings.__PropertyOffset_Debug, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.Debug.CopyAssign(value);
			}
		}

		// Token: 0x17009112 RID: 37138
		// (get) Token: 0x06025AFE RID: 154366 RVA: 0x00391CAC File Offset: 0x0038FEAC
		// (set) Token: 0x06025AFF RID: 154367 RVA: 0x00391CEF File Offset: 0x0038FEEF
		public TArray<EKooSharpMonoTraceMask> DebugGame
		{
			get
			{
				base.FastCheckIsValid();
				TArray<EKooSharpMonoTraceMask> result;
				if ((result = this._DebugGame) == null)
				{
					result = (this._DebugGame = new TArray<EKooSharpMonoTraceMask>(base.NativePtr + (IntPtr)FKooSharpMonoTraceMaskRuntimeSettings.__PropertyOffset_DebugGame, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.DebugGame.CopyAssign(value);
			}
		}

		// Token: 0x17009113 RID: 37139
		// (get) Token: 0x06025B00 RID: 154368 RVA: 0x00391D00 File Offset: 0x0038FF00
		// (set) Token: 0x06025B01 RID: 154369 RVA: 0x00391D43 File Offset: 0x0038FF43
		public TArray<EKooSharpMonoTraceMask> Development
		{
			get
			{
				base.FastCheckIsValid();
				TArray<EKooSharpMonoTraceMask> result;
				if ((result = this._Development) == null)
				{
					result = (this._Development = new TArray<EKooSharpMonoTraceMask>(base.NativePtr + (IntPtr)FKooSharpMonoTraceMaskRuntimeSettings.__PropertyOffset_Development, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.Development.CopyAssign(value);
			}
		}

		// Token: 0x17009114 RID: 37140
		// (get) Token: 0x06025B02 RID: 154370 RVA: 0x00391D54 File Offset: 0x0038FF54
		// (set) Token: 0x06025B03 RID: 154371 RVA: 0x00391D97 File Offset: 0x0038FF97
		public TArray<EKooSharpMonoTraceMask> Test
		{
			get
			{
				base.FastCheckIsValid();
				TArray<EKooSharpMonoTraceMask> result;
				if ((result = this._Test) == null)
				{
					result = (this._Test = new TArray<EKooSharpMonoTraceMask>(base.NativePtr + (IntPtr)FKooSharpMonoTraceMaskRuntimeSettings.__PropertyOffset_Test, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.Test.CopyAssign(value);
			}
		}

		// Token: 0x17009115 RID: 37141
		// (get) Token: 0x06025B04 RID: 154372 RVA: 0x00391DA8 File Offset: 0x0038FFA8
		// (set) Token: 0x06025B05 RID: 154373 RVA: 0x00391DEB File Offset: 0x0038FFEB
		public TArray<EKooSharpMonoTraceMask> Shipping
		{
			get
			{
				base.FastCheckIsValid();
				TArray<EKooSharpMonoTraceMask> result;
				if ((result = this._Shipping) == null)
				{
					result = (this._Shipping = new TArray<EKooSharpMonoTraceMask>(base.NativePtr + (IntPtr)FKooSharpMonoTraceMaskRuntimeSettings.__PropertyOffset_Shipping, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.Shipping.CopyAssign(value);
			}
		}

		// Token: 0x06025B06 RID: 154374 RVA: 0x00391DF9 File Offset: 0x0038FFF9
		public FKooSharpMonoTraceMaskRuntimeSettings()
		{
		}

		// Token: 0x06025B07 RID: 154375 RVA: 0x00391E01 File Offset: 0x00390001
		public FKooSharpMonoTraceMaskRuntimeSettings(TArray<EKooSharpMonoTraceMask> Debug, TArray<EKooSharpMonoTraceMask> DebugEditor, TArray<EKooSharpMonoTraceMask> DebugGame, TArray<EKooSharpMonoTraceMask> DebugGameEditor, TArray<EKooSharpMonoTraceMask> Development, TArray<EKooSharpMonoTraceMask> DevelopmentEditor, TArray<EKooSharpMonoTraceMask> Test, TArray<EKooSharpMonoTraceMask> Shipping)
		{
			this.Debug = Debug;
			this.DebugGame = DebugGame;
			this.Development = Development;
			this.Test = Test;
			this.Shipping = Shipping;
		}

		// Token: 0x06025B08 RID: 154376 RVA: 0x00391E2F File Offset: 0x0039002F
		protected override IntPtr GetUStructPtr()
		{
			return FKooSharpMonoTraceMaskRuntimeSettings.StaticStruct();
		}

		// Token: 0x06025B09 RID: 154377 RVA: 0x00391E3B File Offset: 0x0039003B
		[NullableContext(2)]
		public FKooSharpMonoTraceMaskRuntimeSettings(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06025B0A RID: 154378 RVA: 0x00391E45 File Offset: 0x00390045
		public FKooSharpMonoTraceMaskRuntimeSettings(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06025B0B RID: 154379 RVA: 0x00391E50 File Offset: 0x00390050
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FKooSharpMonoTraceMaskRuntimeSettings(Pointer, false, true);
		}

		// Token: 0x06025B0C RID: 154380 RVA: 0x00391E5A File Offset: 0x0039005A
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FKooSharpMonoTraceMaskRuntimeSettings(Pointer, MemoryOwner);
		}

		// Token: 0x04014835 RID: 84021
		public const string __ObjectPath = "/Script/Sharphereal.KooSharpMonoTraceMaskRuntimeSettings";

		// Token: 0x04014836 RID: 84022
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04014837 RID: 84023
		internal static int __PropertyOffset_Debug;

		// Token: 0x04014838 RID: 84024
		[Nullable(2)]
		private TArray<EKooSharpMonoTraceMask> _Debug;

		// Token: 0x04014839 RID: 84025
		internal static int __PropertyOffset_DebugGame;

		// Token: 0x0401483A RID: 84026
		[Nullable(2)]
		private TArray<EKooSharpMonoTraceMask> _DebugGame;

		// Token: 0x0401483B RID: 84027
		internal static int __PropertyOffset_Development;

		// Token: 0x0401483C RID: 84028
		[Nullable(2)]
		private TArray<EKooSharpMonoTraceMask> _Development;

		// Token: 0x0401483D RID: 84029
		internal static int __PropertyOffset_Test;

		// Token: 0x0401483E RID: 84030
		[Nullable(2)]
		private TArray<EKooSharpMonoTraceMask> _Test;

		// Token: 0x0401483F RID: 84031
		internal static int __PropertyOffset_Shipping;

		// Token: 0x04014840 RID: 84032
		[Nullable(2)]
		private TArray<EKooSharpMonoTraceMask> _Shipping;
	}
}
