using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020008A1 RID: 2209
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.BandwidthTestItem")]
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 16)]
	public class FBandwidthTestItem : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060078D3 RID: 30931 RVA: 0x000AD020 File Offset: 0x000AB220
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FBandwidthTestItem._ScriptStructPtr != 0) ? FBandwidthTestItem._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.BandwidthTestItem", ref FBandwidthTestItem._ScriptStructPtr);
		}

		// Token: 0x17001C86 RID: 7302
		// (get) Token: 0x060078D4 RID: 30932 RVA: 0x000AD044 File Offset: 0x000AB244
		// (set) Token: 0x060078D5 RID: 30933 RVA: 0x000AD087 File Offset: 0x000AB287
		public TArray<byte> Kilobyte
		{
			get
			{
				base.FastCheckIsValid();
				TArray<byte> result;
				if ((result = this._Kilobyte) == null)
				{
					result = (this._Kilobyte = new TArray<byte>(base.NativePtr + (IntPtr)FBandwidthTestItem.__PropertyOffset_Kilobyte, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.Kilobyte.CopyAssign(value);
			}
		}

		// Token: 0x060078D6 RID: 30934 RVA: 0x000AD095 File Offset: 0x000AB295
		public FBandwidthTestItem()
		{
		}

		// Token: 0x060078D7 RID: 30935 RVA: 0x000AD09D File Offset: 0x000AB29D
		public FBandwidthTestItem(TArray<byte> Kilobyte)
		{
			this.Kilobyte = Kilobyte;
		}

		// Token: 0x060078D8 RID: 30936 RVA: 0x000AD0AC File Offset: 0x000AB2AC
		protected override IntPtr GetUStructPtr()
		{
			return FBandwidthTestItem.StaticStruct();
		}

		// Token: 0x060078D9 RID: 30937 RVA: 0x000AD0B8 File Offset: 0x000AB2B8
		[NullableContext(2)]
		public FBandwidthTestItem(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060078DA RID: 30938 RVA: 0x000AD0C2 File Offset: 0x000AB2C2
		public FBandwidthTestItem(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060078DB RID: 30939 RVA: 0x000AD0CD File Offset: 0x000AB2CD
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FBandwidthTestItem(Pointer, false, true);
		}

		// Token: 0x060078DC RID: 30940 RVA: 0x000AD0D7 File Offset: 0x000AB2D7
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FBandwidthTestItem(Pointer, MemoryOwner);
		}

		// Token: 0x04003A09 RID: 14857
		public const string __ObjectPath = "/Script/Engine.BandwidthTestItem";

		// Token: 0x04003A0A RID: 14858
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04003A0B RID: 14859
		internal static int __PropertyOffset_Kilobyte;

		// Token: 0x04003A0C RID: 14860
		[Nullable(2)]
		private TArray<byte> _Kilobyte;
	}
}
