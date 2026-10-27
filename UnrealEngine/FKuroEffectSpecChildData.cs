using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020018CF RID: 6351
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroGameplay.KuroEffectSpecChildData")]
	[UnrealStructLayout(24, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 24)]
	public class FKuroEffectSpecChildData : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060177F5 RID: 96245 RVA: 0x0022674C File Offset: 0x0022494C
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FKuroEffectSpecChildData._ScriptStructPtr != 0) ? FKuroEffectSpecChildData._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroGameplay.KuroEffectSpecChildData", ref FKuroEffectSpecChildData._ScriptStructPtr);
		}

		// Token: 0x17005EE5 RID: 24293
		// (get) Token: 0x060177F6 RID: 96246 RVA: 0x00226770 File Offset: 0x00224970
		// (set) Token: 0x060177F7 RID: 96247 RVA: 0x00226780 File Offset: 0x00224980
		public unsafe int Id
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroEffectSpecChildData.__PropertyOffset_Id);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroEffectSpecChildData.__PropertyOffset_Id) = value;
			}
		}

		// Token: 0x17005EE6 RID: 24294
		// (get) Token: 0x060177F8 RID: 96248 RVA: 0x00226794 File Offset: 0x00224994
		// (set) Token: 0x060177F9 RID: 96249 RVA: 0x002267D7 File Offset: 0x002249D7
		public TArray<int> Children
		{
			get
			{
				base.FastCheckIsValid();
				TArray<int> result;
				if ((result = this._Children) == null)
				{
					result = (this._Children = new TArray<int>(base.NativePtr + (IntPtr)FKuroEffectSpecChildData.__PropertyOffset_Children, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.Children.CopyAssign(value);
			}
		}

		// Token: 0x060177FA RID: 96250 RVA: 0x002267E5 File Offset: 0x002249E5
		public FKuroEffectSpecChildData()
		{
		}

		// Token: 0x060177FB RID: 96251 RVA: 0x002267ED File Offset: 0x002249ED
		public FKuroEffectSpecChildData(int Id, TArray<int> Children)
		{
			this.Id = Id;
			this.Children = Children;
		}

		// Token: 0x060177FC RID: 96252 RVA: 0x00226803 File Offset: 0x00224A03
		protected override IntPtr GetUStructPtr()
		{
			return FKuroEffectSpecChildData.StaticStruct();
		}

		// Token: 0x060177FD RID: 96253 RVA: 0x0022680F File Offset: 0x00224A0F
		[NullableContext(2)]
		public FKuroEffectSpecChildData(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060177FE RID: 96254 RVA: 0x00226819 File Offset: 0x00224A19
		public FKuroEffectSpecChildData(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060177FF RID: 96255 RVA: 0x00226824 File Offset: 0x00224A24
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FKuroEffectSpecChildData(Pointer, false, true);
		}

		// Token: 0x06017800 RID: 96256 RVA: 0x0022682E File Offset: 0x00224A2E
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FKuroEffectSpecChildData(Pointer, MemoryOwner);
		}

		// Token: 0x0400CC81 RID: 52353
		public const string __ObjectPath = "/Script/KuroGameplay.KuroEffectSpecChildData";

		// Token: 0x0400CC82 RID: 52354
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400CC83 RID: 52355
		internal static int __PropertyOffset_Id;

		// Token: 0x0400CC84 RID: 52356
		internal static int __PropertyOffset_Children;

		// Token: 0x0400CC85 RID: 52357
		[Nullable(2)]
		private TArray<int> _Children;
	}
}
