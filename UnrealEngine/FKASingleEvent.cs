using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020015E4 RID: 5604
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KRDataAnalyticsPlugin.KASingleEvent")]
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 16)]
	public class FKASingleEvent : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06014344 RID: 82756 RVA: 0x001DAD6E File Offset: 0x001D8F6E
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FKASingleEvent._ScriptStructPtr != 0) ? FKASingleEvent._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KRDataAnalyticsPlugin.KASingleEvent", ref FKASingleEvent._ScriptStructPtr);
		}

		// Token: 0x17004F42 RID: 20290
		// (get) Token: 0x06014345 RID: 82757 RVA: 0x001DAD94 File Offset: 0x001D8F94
		// (set) Token: 0x06014346 RID: 82758 RVA: 0x001DADD7 File Offset: 0x001D8FD7
		public TArray<byte> Utf8StringCode
		{
			get
			{
				base.FastCheckIsValid();
				TArray<byte> result;
				if ((result = this._Utf8StringCode) == null)
				{
					result = (this._Utf8StringCode = new TArray<byte>(base.NativePtr + (IntPtr)FKASingleEvent.__PropertyOffset_Utf8StringCode, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.Utf8StringCode.CopyAssign(value);
			}
		}

		// Token: 0x06014347 RID: 82759 RVA: 0x001DADE5 File Offset: 0x001D8FE5
		public FKASingleEvent()
		{
		}

		// Token: 0x06014348 RID: 82760 RVA: 0x001DADED File Offset: 0x001D8FED
		public FKASingleEvent(TArray<byte> Utf8StringCode)
		{
			this.Utf8StringCode = Utf8StringCode;
		}

		// Token: 0x06014349 RID: 82761 RVA: 0x001DADFC File Offset: 0x001D8FFC
		protected override IntPtr GetUStructPtr()
		{
			return FKASingleEvent.StaticStruct();
		}

		// Token: 0x0601434A RID: 82762 RVA: 0x001DAE08 File Offset: 0x001D9008
		[NullableContext(2)]
		public FKASingleEvent(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601434B RID: 82763 RVA: 0x001DAE12 File Offset: 0x001D9012
		public FKASingleEvent(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601434C RID: 82764 RVA: 0x001DAE1D File Offset: 0x001D901D
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FKASingleEvent(Pointer, false, true);
		}

		// Token: 0x0601434D RID: 82765 RVA: 0x001DAE27 File Offset: 0x001D9027
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FKASingleEvent(Pointer, MemoryOwner);
		}

		// Token: 0x0400AFD5 RID: 45013
		public const string __ObjectPath = "/Script/KRDataAnalyticsPlugin.KASingleEvent";

		// Token: 0x0400AFD6 RID: 45014
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400AFD7 RID: 45015
		internal static int __PropertyOffset_Utf8StringCode;

		// Token: 0x0400AFD8 RID: 45016
		[Nullable(2)]
		private TArray<byte> _Utf8StringCode;
	}
}
