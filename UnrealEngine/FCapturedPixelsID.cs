using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020022FF RID: 8959
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/MovieSceneCapture.CapturedPixelsID")]
	[UnrealStructLayout(80, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 80)]
	public class FCapturedPixelsID : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06021F30 RID: 139056 RVA: 0x003234F2 File Offset: 0x003216F2
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FCapturedPixelsID._ScriptStructPtr != 0) ? FCapturedPixelsID._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/MovieSceneCapture.CapturedPixelsID", ref FCapturedPixelsID._ScriptStructPtr);
		}

		// Token: 0x1700833A RID: 33594
		// (get) Token: 0x06021F31 RID: 139057 RVA: 0x00323518 File Offset: 0x00321718
		// (set) Token: 0x06021F32 RID: 139058 RVA: 0x0032355B File Offset: 0x0032175B
		public TMap<FName, FName> Identifiers
		{
			get
			{
				base.FastCheckIsValid();
				TMap<FName, FName> result;
				if ((result = this._Identifiers) == null)
				{
					result = (this._Identifiers = new TMap<FName, FName>(base.NativePtr + (IntPtr)FCapturedPixelsID.__PropertyOffset_Identifiers, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.Identifiers.CopyAssign(value);
			}
		}

		// Token: 0x06021F33 RID: 139059 RVA: 0x00323569 File Offset: 0x00321769
		public FCapturedPixelsID()
		{
		}

		// Token: 0x06021F34 RID: 139060 RVA: 0x00323571 File Offset: 0x00321771
		public FCapturedPixelsID(TMap<FName, FName> Identifiers)
		{
			this.Identifiers = Identifiers;
		}

		// Token: 0x06021F35 RID: 139061 RVA: 0x00323580 File Offset: 0x00321780
		protected override IntPtr GetUStructPtr()
		{
			return FCapturedPixelsID.StaticStruct();
		}

		// Token: 0x06021F36 RID: 139062 RVA: 0x0032358C File Offset: 0x0032178C
		[NullableContext(2)]
		public FCapturedPixelsID(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06021F37 RID: 139063 RVA: 0x00323596 File Offset: 0x00321796
		public FCapturedPixelsID(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06021F38 RID: 139064 RVA: 0x003235A1 File Offset: 0x003217A1
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FCapturedPixelsID(Pointer, false, true);
		}

		// Token: 0x06021F39 RID: 139065 RVA: 0x003235AB File Offset: 0x003217AB
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FCapturedPixelsID(Pointer, MemoryOwner);
		}

		// Token: 0x040121B9 RID: 74169
		public const string __ObjectPath = "/Script/MovieSceneCapture.CapturedPixelsID";

		// Token: 0x040121BA RID: 74170
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040121BB RID: 74171
		internal static int __PropertyOffset_Identifiers;

		// Token: 0x040121BC RID: 74172
		[Nullable(2)]
		private TMap<FName, FName> _Identifiers;
	}
}
