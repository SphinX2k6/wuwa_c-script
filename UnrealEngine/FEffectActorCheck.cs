using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000A69 RID: 2665
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.EffectActorCheck")]
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 16)]
	public class FEffectActorCheck : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06008FDF RID: 36831 RVA: 0x000CDEAF File Offset: 0x000CC0AF
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FEffectActorCheck._ScriptStructPtr != 0) ? FEffectActorCheck._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.EffectActorCheck", ref FEffectActorCheck._ScriptStructPtr);
		}

		// Token: 0x170021F7 RID: 8695
		// (get) Token: 0x06008FE0 RID: 36832 RVA: 0x000CDED4 File Offset: 0x000CC0D4
		// (set) Token: 0x06008FE1 RID: 36833 RVA: 0x000CDF17 File Offset: 0x000CC117
		public TArray<string> PlayTypeForcePlayPath
		{
			get
			{
				base.FastCheckIsValid();
				TArray<string> result;
				if ((result = this._PlayTypeForcePlayPath) == null)
				{
					result = (this._PlayTypeForcePlayPath = new TArray<string>(base.NativePtr + (IntPtr)FEffectActorCheck.__PropertyOffset_PlayTypeForcePlayPath, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.PlayTypeForcePlayPath.CopyAssign(value);
			}
		}

		// Token: 0x06008FE2 RID: 36834 RVA: 0x000CDF25 File Offset: 0x000CC125
		public FEffectActorCheck()
		{
		}

		// Token: 0x06008FE3 RID: 36835 RVA: 0x000CDF2D File Offset: 0x000CC12D
		public FEffectActorCheck(TArray<string> PlayTypeForcePlayPath)
		{
			this.PlayTypeForcePlayPath = PlayTypeForcePlayPath;
		}

		// Token: 0x06008FE4 RID: 36836 RVA: 0x000CDF3C File Offset: 0x000CC13C
		protected override IntPtr GetUStructPtr()
		{
			return FEffectActorCheck.StaticStruct();
		}

		// Token: 0x06008FE5 RID: 36837 RVA: 0x000CDF48 File Offset: 0x000CC148
		[NullableContext(2)]
		public FEffectActorCheck(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06008FE6 RID: 36838 RVA: 0x000CDF52 File Offset: 0x000CC152
		public FEffectActorCheck(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06008FE7 RID: 36839 RVA: 0x000CDF5D File Offset: 0x000CC15D
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FEffectActorCheck(Pointer, false, true);
		}

		// Token: 0x06008FE8 RID: 36840 RVA: 0x000CDF67 File Offset: 0x000CC167
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FEffectActorCheck(Pointer, MemoryOwner);
		}

		// Token: 0x04004784 RID: 18308
		public const string __ObjectPath = "/Script/Engine.EffectActorCheck";

		// Token: 0x04004785 RID: 18309
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04004786 RID: 18310
		internal static int __PropertyOffset_PlayTypeForcePlayPath;

		// Token: 0x04004787 RID: 18311
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<string> _PlayTypeForcePlayPath;
	}
}
