using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02001B07 RID: 6919
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroRenderingRuntimeBPPlugin.KuroGIExtendedMPCSetting")]
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 16)]
	public class FKuroGIExtendedMPCSetting : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06019E96 RID: 106134 RVA: 0x00263ED2 File Offset: 0x002620D2
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FKuroGIExtendedMPCSetting._ScriptStructPtr != 0) ? FKuroGIExtendedMPCSetting._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroRenderingRuntimeBPPlugin.KuroGIExtendedMPCSetting", ref FKuroGIExtendedMPCSetting._ScriptStructPtr);
		}

		// Token: 0x170067D7 RID: 26583
		// (get) Token: 0x06019E97 RID: 106135 RVA: 0x00263EF8 File Offset: 0x002620F8
		// (set) Token: 0x06019E98 RID: 106136 RVA: 0x00263F3B File Offset: 0x0026213B
		public TArray<FKuroGIExtendedMPCEntry> Entries
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FKuroGIExtendedMPCEntry> result;
				if ((result = this._Entries) == null)
				{
					result = (this._Entries = new TArray<FKuroGIExtendedMPCEntry>(base.NativePtr + (IntPtr)FKuroGIExtendedMPCSetting.__PropertyOffset_Entries, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.Entries.CopyAssign(value);
			}
		}

		// Token: 0x06019E99 RID: 106137 RVA: 0x00263F49 File Offset: 0x00262149
		public FKuroGIExtendedMPCSetting()
		{
		}

		// Token: 0x06019E9A RID: 106138 RVA: 0x00263F51 File Offset: 0x00262151
		public FKuroGIExtendedMPCSetting(TArray<FKuroGIExtendedMPCEntry> Entries)
		{
			this.Entries = Entries;
		}

		// Token: 0x06019E9B RID: 106139 RVA: 0x00263F60 File Offset: 0x00262160
		protected override IntPtr GetUStructPtr()
		{
			return FKuroGIExtendedMPCSetting.StaticStruct();
		}

		// Token: 0x06019E9C RID: 106140 RVA: 0x00263F6C File Offset: 0x0026216C
		[NullableContext(2)]
		public FKuroGIExtendedMPCSetting(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06019E9D RID: 106141 RVA: 0x00263F76 File Offset: 0x00262176
		public FKuroGIExtendedMPCSetting(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06019E9E RID: 106142 RVA: 0x00263F81 File Offset: 0x00262181
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FKuroGIExtendedMPCSetting(Pointer, false, true);
		}

		// Token: 0x06019E9F RID: 106143 RVA: 0x00263F8B File Offset: 0x0026218B
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FKuroGIExtendedMPCSetting(Pointer, MemoryOwner);
		}

		// Token: 0x0400E156 RID: 57686
		public const string __ObjectPath = "/Script/KuroRenderingRuntimeBPPlugin.KuroGIExtendedMPCSetting";

		// Token: 0x0400E157 RID: 57687
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400E158 RID: 57688
		internal static int __PropertyOffset_Entries;

		// Token: 0x0400E159 RID: 57689
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FKuroGIExtendedMPCEntry> _Entries;
	}
}
