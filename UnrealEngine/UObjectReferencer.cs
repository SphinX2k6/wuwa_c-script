using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000EFC RID: 3836
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.ObjectReferencer")]
	[UnrealStructLayout(64, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 64)]
	public class UObjectReferencer : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600CFD5 RID: 53205 RVA: 0x0012F252 File Offset: 0x0012D452
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UObjectReferencer._ClassPtr;
		}

		// Token: 0x0600CFD6 RID: 53206 RVA: 0x0012F260 File Offset: 0x0012D460
		public UObjectReferencer() : this(BuiltinUtils.AllocNativeUObject(UObjectReferencer.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600CFD7 RID: 53207 RVA: 0x0012F288 File Offset: 0x0012D488
		public UObjectReferencer(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UObjectReferencer.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17003104 RID: 12548
		// (get) Token: 0x0600CFD8 RID: 53208 RVA: 0x0012F2BC File Offset: 0x0012D4BC
		// (set) Token: 0x0600CFD9 RID: 53209 RVA: 0x0012F2F5 File Offset: 0x0012D4F5
		public TArray<UObject> ReferencedObjects
		{
			get
			{
				base.FastCheckIsValid();
				TArray<UObject> result;
				if ((result = this._ReferencedObjects) == null)
				{
					result = (this._ReferencedObjects = new TArray<UObject>(base.NativePtr + (IntPtr)UObjectReferencer.__PropertyOffset_ReferencedObjects, this));
				}
				return result;
			}
			set
			{
				this.ReferencedObjects.CopyAssign(value);
			}
		}

		// Token: 0x0600CFDA RID: 53210 RVA: 0x0012F303 File Offset: 0x0012D503
		static UObjectReferencer()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.ObjectReferencer");
		}

		// Token: 0x0600CFDB RID: 53211 RVA: 0x0012F311 File Offset: 0x0012D511
		protected UObjectReferencer(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04007008 RID: 28680
		public new const string __ObjectPath = "/Script/Engine.ObjectReferencer";

		// Token: 0x04007009 RID: 28681
		private static IntPtr _ClassPtr;

		// Token: 0x0400700A RID: 28682
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400700B RID: 28683
		internal static int __PropertyOffset_ReferencedObjects;

		// Token: 0x0400700C RID: 28684
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UObject> _ReferencedObjects;
	}
}
